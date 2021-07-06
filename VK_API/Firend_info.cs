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
            var api_user = new VkApi();
            // обработать исключения!
            api_user.Authorize(new ApiAuthParams
            {
                AccessToken = token
            });
            // получить список друзей (для пользователя)
            var getFriends = api_user.Friends.Get(new VkNet.Model.RequestParams.FriendsGetParams
            {
                Fields = VkNet.Enums.Filters.ProfileFields.All
            });
            foreach (User user in getFriends)
                Friend.Items.Add(Encoding.UTF8.GetString(Encoding.Default.GetBytes(user.FirstName)) + " " + Encoding.UTF8.GetString(Encoding.Default.GetBytes(user.LastName)));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Frend_info_Load(object sender, EventArgs e)
        {

        }
    }
}
