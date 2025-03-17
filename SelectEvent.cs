using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GoDoCreater.SelectServer;

namespace GoDoCreater
{
    public partial class SelectEvent : Form
    {
        public SelectEvent()
        {
            InitializeComponent();
            this.ResumeLayout(true);
            ShowEventList();
        }
        public void ShowEventList()
        {
            string connectionString = GlobalV.MagicHead + GlobalV.ServerName + GlobalV.MagicWord;
            string sqlQuery = "select * from 大会設定";
            listEvent.Items.Clear();

            listEvent.DrawMode = DrawMode.OwnerDrawFixed;
            listEvent.DrawItem += (sender, e) =>
            {
                e.DrawBackground();
                if (e.Index >= 0)
                {
#pragma warning disable CS8600 // Null リテラルまたは Null の可能性がある値を Null 非許容型に変換しています。
                    string item = listEvent.Items[e.Index].ToString();
#pragma warning restore CS8600 // Null リテラルまたは Null の可能性がある値を Null 非許容型に変換しています。
#pragma warning disable CS8602 // Null リテラルまたは Null の可能性がある値を Null 非許容型に変換しています。
                    string[] parts = item.Split('|'); // "|" 区切りでアイテムを分割

#pragma warning restore CS8602 // Null リテラルまたは Null の可能性がある値を Null 非許容型に変換しています。
                    // カラムごとに描画
                    int x = e.Bounds.Left;
#pragma warning disable CS8604 // Null リテラルまたは Null の可能性がある値を Null 非許容型に変換しています。
                    e.Graphics.DrawString(parts[0], e.Font, Brushes.Black, x, e.Bounds.Top);
#pragma warning restore CS8604 // Null リテラルまたは Null の可能性がある値を Null 非許容型に変換しています。
                    x += 60; // カラムの位置調整
                    e.Graphics.DrawString(parts[1], e.Font, Brushes.Black, x, e.Bounds.Top);
                    x += 680;
                    e.Graphics.DrawString(parts[2], e.Font, Brushes.Black, x, e.Bounds.Top);
                    x += 550;
                    e.Graphics.DrawString(parts[3], e.Font, Brushes.Black, x, e.Bounds.Top);
                }
                e.DrawFocusRectangle();
            };

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string eventNo;
                                string eventName;
                                string eventDate;
                                string eventStart;
                                string eventEnd;
                                string eventVenue;
                                eventNo = "" + reader["大会番号"];
                                eventName = "" + reader["大会名1"];
                                eventVenue = "" + reader["開催地"];
                                eventStart = "" + reader["始期間"];
                                eventEnd = "" + reader["終期間"];
                                if (eventStart == eventEnd)
                                {
                                    eventDate = Space(6) + eventStart + Space(6);
                                }
                                else
                                {
                                    eventDate = eventStart + "～" + eventEnd;
                                }
                                string showStr = Right(eventNo, 3) + "|" +
                                    eventName + "|" +
                                    eventVenue + "|" +
                                    eventDate;
                                listEvent.Items.Add(showStr);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("エラー [ ShowEvnetList ] \n" + ex.Message);
            }


        }
        public static new string Right(string input, int length)
        {
            string head = new string(' ', length);

            string untrim = head + input;
            return untrim.Substring(untrim.Length - length, length);

        }
        public static string Space(int length)
        {
            if (length <= 0)
            {
                return string.Empty;
            }
            return new string(' ', length);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {


            var selectedItem = listEvent.SelectedItem;
            if (selectedItem != null)
            {
#pragma warning disable CS8602 // Null リテラルまたは Null の可能性がある値を Null 非許容型に変換しています。
                GlobalV.EventNo = Int32.Parse(selectedItem.ToString()[..3]);
                MainMenu mainMenu = new(selectedItem.ToString());
                mainMenu.Show();
#pragma warning restore CS8602 // Null リテラルまたは Null の可能性がある値を Null 非許容型に変換しています。
            }
            else
            {
                MessageBox.Show("大会が選択されていません");
            }


        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void checkBoxScenario2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
