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
using VkNet.Model;
using VkNet.Enums.Filters;
using VkNet.Model.RequestParams;

namespace VK_API
{
    public partial class Firend_info : Form
    {
        string token;

        public Firend_info(string tok)
        {
            InitializeComponent();
            token = tok;
            bd_checkBox.Enabled = false;
            Status_checkBox.Enabled = false;
            Sex_checkBox.Enabled = false;
            ID_checkBox.Enabled = false;
            Online_checkBox.Enabled = false;
            Mutual_friends_checkBox.Enabled = false;
                var api_user = new VkApi();
            try
            {
                api_user.Authorize(new ApiAuthParams
                {
                    AccessToken = token
                });
                // получить список друзей 
                var getFriends = api_user.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams
                {
                    Fields = VkNet.Enums.Filters.ProfileFields.All
                });
                foreach (User user in getFriends)
                {
                    Friend.Items.Add(Encoding.UTF8.GetString(Encoding.Default.GetBytes(user.FirstName)) + " " + Encoding.UTF8.GetString(Encoding.Default.GetBytes(user.LastName)));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка: " + e.Message);
                
            }
         }


        private void Filtr_Changed(object sender, EventArgs e)
        {
            int si = Friend.SelectedIndex;
            Sex_checkBox.Enabled = true;
            bd_checkBox.Enabled = true;
            Status_checkBox.Enabled = true;
            ID_checkBox.Enabled = true;
            Online_checkBox.Enabled = true;
            Mutual_friends_checkBox.Enabled = true;
            var api_user = new VkApi();
            api_user.Authorize(new ApiAuthParams
            {
                AccessToken = token
            });
            // получить список друзей (для пользователя)
            var getFriends = api_user.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams
            {
                Fields = VkNet.Enums.Filters.ProfileFields.All
            });
            textBox1.Text = Encoding.UTF8.GetString(Encoding.Default.GetBytes(getFriends[si].FirstName)) + " " + Encoding.UTF8.GetString(Encoding.Default.GetBytes(getFriends[si].LastName)) + Environment.NewLine;
            //Вывод ID
            if (ID_checkBox.Checked)
            {
                textBox1.Text += "ID:" + Environment.NewLine + getFriends[si].Domain + Environment.NewLine; 
            }
            // Вывод пола
            if (Sex_checkBox.Checked)
            {
                textBox1.Text += "Пол:" + Environment.NewLine;
                textBox1.Text += getFriends[si].Sex + Environment.NewLine;
            }
            // Вывод дня рождения
            if (bd_checkBox.Checked)
            {
                textBox1.Text += "День рождения:" + Environment.NewLine;
                try
                {
                    textBox1.Text += Encoding.UTF8.GetString(Encoding.Default.GetBytes(getFriends[si].BirthDate)) + Environment.NewLine;
                }
                catch
                {
                    textBox1.Text += "*** НЕ УКАЗАНА ***" + Environment.NewLine;
                }
            }
            // Вывод статуса
            if (Status_checkBox.Checked)
            {
                textBox1.Text += "Статус:" + Environment.NewLine;
                try
                {
                    if (Encoding.UTF8.GetString(Encoding.Default.GetBytes(getFriends[si].Status)) != "")
                        textBox1.Text += Encoding.UTF8.GetString(Encoding.Default.GetBytes(getFriends[si].Status)) + Environment.NewLine;
                    else textBox1.Text += "*** НЕ УКАЗАНО ***" + Environment.NewLine;
                }
                catch
                {
                    textBox1.Text += "*** НЕ УКАЗАНО ***" + Environment.NewLine;
                }
            }
            // Последний раз был в сети
            if (Online_checkBox.Checked)
            {
                textBox1.Text += "Последний раз в сети:" + Environment.NewLine + getFriends[si].LastSeen.Time + Environment.NewLine;
            }
            // Общие друзья
            if (Mutual_friends_checkBox.Checked)
            {
                textBox1.Text += "Общие друзья:" + Environment.NewLine;
                var f_friends = api_user.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams
                {
                    UserId = getFriends[si].Id,
                    Fields = ProfileFields.Domain,
                });
                foreach (User f_friend in f_friends)
                {
                    string domian = f_friend.Domain;
                    foreach( User my_friend in getFriends)
                        if (domian == my_friend.Domain)
                            textBox1.Text += Encoding.UTF8.GetString(Encoding.Default.GetBytes(my_friend.FirstName)) + " " + Encoding.UTF8.GetString(Encoding.Default.GetBytes(my_friend.LastName)) + Environment.NewLine;
                }
            }

        }

        private void Firend_info_Load(object sender, EventArgs e)
        {
            
        }

        private void Firend_info_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

