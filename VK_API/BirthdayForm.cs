using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;

namespace VK_API
{
    public partial class BirthdayForm : Form
    {
        class User
        {
            public Uri photo;
            public string first_name;
            public string last_name;
            public long id;
            public User(VkNet.Model.User u)
            {
                this.first_name = u.FirstName;
                this.last_name = u.LastName;
                this.photo = u.Photo200;
                this.id = u.Id;
            }

        }

        VkApi api;
        List<User> users;

        public BirthdayForm(string token, string group_id)
        {
            InitializeComponent();

            api = new VkApi();

            api.Authorize(new VkNet.Model.ApiAuthParams
            {
                AccessToken = token
            });

            string today = DateTime.Now.ToString("d.M");
            users = new List<User>();

            try
            {
                var ids = api.Groups.GetMembers(new VkNet.Model.RequestParams.GroupsGetMembersParams()
                {
                    GroupId = group_id,
                    Fields =
                        VkNet.Enums.Filters.UsersFields.BirthDate |
                        VkNet.Enums.Filters.UsersFields.Photo200
                });
                foreach (var id in ids)
                {
                    if (id.BirthDate == null)
                        continue;

                    var t = id.BirthDate.Split('.');
                    string bd = t[0] + "." + t[1];
                    if (bd != today)
                        continue;

                    User u = new User(id);
                    users.Add(u);
                    users_listbox.Items.Add(Encoding.UTF8.GetString(Encoding.Default.GetBytes(id.FirstName)) + " " + Encoding.UTF8.GetString(Encoding.Default.GetBytes(id.LastName)));
                }

                if (users.Count == 0)
                {
                    MessageBox.Show("В данной группе не найдено пользователей у которых сегодня день рождения. Попробуйте другую");
                    this.Close();
                }
                else
                    this.Show();
            }
            catch (VkNet.Exception.GroupAccessDeniedException)
            {
                MessageBox.Show("У вас нет доступа к группе");
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка: " + e.Message);
            }
        }

        private void users_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = users_listbox.SelectedIndex;
            if (index < 0)
                return;
            textBox1.Text = "C ДНЕМ РОЖДЕНИЯ, " + Encoding.UTF8.GetString(Encoding.Default.GetBytes(users[index].first_name)).ToUpper()+" "+ Encoding.UTF8.GetString(Encoding.Default.GetBytes(users[index].last_name)).ToUpper()+"!";
            photo.Load(users[index].photo.ToString());
        }

        private void copy_link_Click(object sender, EventArgs e)
        {
            int index = users_listbox.SelectedIndex;
            if (index < 0)
                return;

            string link = "https://vk.com/id" + users[index].id;
            Clipboard.SetText(link);
        }

        private void send_Click(object sender, EventArgs e)
        {
            int index = users_listbox.SelectedIndex;
            if (index < 0)
                return;

            DialogResult dialogResult = MessageBox.Show("Вы точно хотите совершит действия?", "Точно?", MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes)
                return;
            if (!Message_checkBox.Checked && !Post_checkBox.Checked) MessageBox.Show("Действие не выбрано");
            if (Message_checkBox.Checked)
            {
                try
                {
                    api.Messages.Send(new VkNet.Model.RequestParams.MessagesSendParams
                    {
                        RandomId = DateTime.Now.ToFileTime(),
                        UserId = users[index].id,
                        Message = textBox1.Text
                    });

                    MessageBox.Show("Сообщение отправлено");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при отправки сообщения\n" + ex.Message);
                }
            }
            if (Post_checkBox.Checked)
                {
                    try
                    {
                        api.Wall.Post(new VkNet.Model.RequestParams.WallPostParams
                        {
                            
                            Message = textBox1.Text
                        });

                        MessageBox.Show("Пост написан");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка при написании поста\n" + ex.Message);
                    }
                }
            }
        }
    }
