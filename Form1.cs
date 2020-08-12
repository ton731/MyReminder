using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyReminder
{
    public partial class Form1 : Form
    {
        //全部的字
        string s;

        //先分成兩邊，共兩個主題
        string[] categories;
        string topic1;
        string topic2;

        //再從主題分成細項
        List<string> items1;
        List<string> items2;

        string temp_store;


        public Form1()
        {
            InitializeComponent();

            //this.Location = new Point(100, 50);


            //設定兩個panel進去時的寬高
            panel1.Height = 240;
            panel2.Height = 240;
            panel1.Width = 330;
            panel2.Width = 330;
            panel1.Top = this.Top;
            panel2.Top = this.Top + panel1.Height;
            panel1.Left = this.Left;
            panel2.Left = this.Left;
            this.Width = 347;
            this.Height = 520;

            //也先預設定新增的panel的位置
            NewItem1Panel.Left = this.Width / 2 - NewItem1Panel.Width / 2;
            NewItem1Panel.Top = this.Height / 2 - NewItem1Panel.Height / 2 - 50;
            NewItem2Panel.Left = this.Width / 2 - NewItem2Panel.Width / 2;
            NewItem2Panel.Top = this.Height / 2 - NewItem2Panel.Height / 2 - 50;

            //也先預設定移除的panel的位置
            Remove1Panel.Left = this.Width / 2 - Remove1Panel.Width / 2;
            Remove1Panel.Top = this.Height / 2 - Remove1Panel.Height / 2 - 50;
            Remove2Panel.Left = this.Width / 2 - Remove2Panel.Width / 2;
            Remove2Panel.Top = this.Height / 2 - Remove2Panel.Height / 2 - 50;


            //也先預先設定上移和下移的panel位置
            MoveDownPanel.Left = this.Width / 2 - MoveDownPanel.Width / 2;
            MoveDownPanel.Top = this.Height / 2 - MoveDownPanel.Height / 2 - 50;
            MoveUpPanel.Left = this.Width / 2 - MoveUpPanel.Width / 2;
            MoveUpPanel.Top = this.Height / 2 - MoveUpPanel.Height / 2 - 50;



            //先讀一次檔案
            LoadText();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //把txt檔案讀進來，存起來
        private void LoadText()
        {
            //先將原本richtextbox裡面的內容清空
            richTextBox1.Text = "";
            richTextBox2.Text = "";


            //讀取txt檔案，將他用*****分類，分派到topic1和topic2
            //using 會自動幫我close file
            string line;
            s = "";
            using (StreamReader file = new StreamReader(@"C:\Users\周遠同\Desktop\ToDoList.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    s += line + "\n";
                }
            }


            string[] seperator = { "*****" };
            categories = s.Split(seperator, StringSplitOptions.None);

            topic1 = categories[0].Trim();
            topic2 = categories[1].Trim();


            //接下來把每一個topic再用***分成一項一項，先trim修剪遺下
            string[] seperator2 = { "***" };
            items1 = topic1.Split(seperator2, StringSplitOptions.None).ToList();
            items2 = topic2.Split(seperator2, StringSplitOptions.None).ToList();

            
            for(int i = 0; i < items1.Count; i++)
            {
                items1[i] = items1[i].Trim();
            }
            
            for (int i = 0; i < items2.Count; i++)
            {
                items2[i] = items2[i].Trim();
            }

            //items1,2的最後一項都會是空白，那我直接先把後面最後一項刪掉，後面就比較不會出現問題
            items1.RemoveAt(items1.Count - 1);
            items2.RemoveAt(items2.Count - 1);


            //把它放到richtextbox中
            foreach (string item in items1)
            {
                if(item != "")
                    richTextBox1.Text += "• " + item + "\n";
            }
            foreach(string item in items2)
            {
                if (item != "")
                    richTextBox2.Text += "• " + item + "\n";
            }

        }



        //增加與移除的按鈕設定
        private void Remove1Button_Click(object sender, EventArgs e)
        {
            //把移除的panel叫出來
            Remove1Panel.Visible = true;

            //然後新增comboBox裡面的選單
            Remove1ComboBox.Items.Clear();
            foreach(string item in items1)
            {
                if (item != "")
                    Remove1ComboBox.Items.Add(item);
            }
        }

        private void Add1Button_Click(object sender, EventArgs e)
        {
            //先把新增的panel叫出來
            NewItem1Panel.Visible = true;
        }

        private void Remove2Button_Click(object sender, EventArgs e)
        {
            //把移除的panel叫出來
            Remove2Panel.Visible = true;

            //然後新增comboBox裡面的選單
            Remove2ComboBox.Items.Clear();
            foreach (string item in items2)
            {
                if (item != "")
                    Remove2ComboBox.Items.Add(item);
            }
        }

        private void Add2Button_Click(object sender, EventArgs e)
        {
            //先把新增的panel叫出來
            NewItem2Panel.Visible = true;
        }




        //新增確認或是取消的button
        private void NewItemOk1Button_Click(object sender, EventArgs e)
        {
            if(NewItem1TextBox.Text == "")
            {
                MessageBox.Show("請輸入事項！");
                return;
            }

            //先把寫入的事項加到topic裡面，再用writer把兩個topic寫進去，重新讀取
            topic1 += "\n" + NewItem1TextBox.Text + "\n" + "***";
            using (StreamWriter file = new StreamWriter(@"C:\Users\周遠同\Desktop\ToDoList.txt"))
            {
                file.WriteLine(topic1);
                file.WriteLine("*****");
                file.WriteLine(topic2);
            }

            NewItem1TextBox.Text = "";
            NewItem1Panel.Visible = false;

            LoadText();
        }

        private void NewItemCancel1Button_Click(object sender, EventArgs e)
        {
            NewItem1Panel.Visible = false;
            NewItem1TextBox.Text = "";
        }

        private void NewItemOk2Button_Click(object sender, EventArgs e)
        {
            if (NewItem2TextBox.Text == "")
            {
                MessageBox.Show("請輸入事項！");
                return;
            }

            //先把寫入的事項加到topic裡面，再用writer把兩個topic寫進去，重新讀取
            topic2 += "\n" + NewItem2TextBox.Text + "\n" + "***";
            using (StreamWriter file = new StreamWriter(@"C:\Users\周遠同\Desktop\ToDoList.txt"))
            {
                file.WriteLine(topic1);
                file.WriteLine("*****");
                file.WriteLine(topic2);
            }

            NewItem2TextBox.Text = "";
            NewItem2Panel.Visible = false;

            LoadText();
        }

        private void NewItemCancel2Button_Click(object sender, EventArgs e)
        {
            NewItem2Panel.Visible = false;
            NewItem2TextBox.Text = "";
        }




        //移除時，確定以及取消的button
        private void RemoveOk1Button_Click(object sender, EventArgs e)
        {
            //按下確定以後，從items刪掉那一項，然後把items重組回topic的字串
            //再把topic1,topic2的字串重新寫回檔案，然後再讀一次檔案
            if(Remove1ComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇已經完成的事項！");
                return;
            }

            topic1 = "";
            for (int i = 0; i < items1.Count; i++)
            {
                if(i != Remove1ComboBox.SelectedIndex && items1[i] != "")
                {
                    topic1 += items1[i] + "\n" + "***" + "\n";
                }
            }

            topic1 = topic1.Trim();

            using (StreamWriter file = new StreamWriter(@"C:\Users\周遠同\Desktop\ToDoList.txt"))
            {
                file.WriteLine(topic1);
                file.WriteLine("*****");
                file.WriteLine(topic2);
            }

            LoadText();

            Remove1Panel.Visible = false;
            Remove1ComboBox.Text = "";
        }

        private void RemoveCancel1Button_Click(object sender, EventArgs e)
        {
            Remove1Panel.Visible = false;
        }

        private void RemoveOk2Button_Click(object sender, EventArgs e)
        {
            //按下確定以後，從items刪掉那一項，然後把items重組回topic的字串
            //再把topic1,topic2的字串重新寫回檔案，然後再讀一次檔案
            if (Remove2ComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("請選擇已經完成的事項！");
                return;
            }

            topic2 = "";
            for (int i = 0; i < items2.Count; i++)
            {
                if (i != Remove2ComboBox.SelectedIndex && items2[i] != "")
                {
                    topic2 += items2[i] + "\n" + "***" + "\n";
                }
            }

            topic2 = topic2.Trim();

            using (StreamWriter file = new StreamWriter(@"C:\Users\周遠同\Desktop\ToDoList.txt"))
            {
                file.WriteLine(topic1);
                file.WriteLine("*****");
                file.WriteLine(topic2);
            }

            LoadText();

            Remove2Panel.Visible = false;
            Remove2ComboBox.Text = "";
        }

        private void RemoveCancel2Button_Click(object sender, EventArgs e)
        {
            Remove2Panel.Visible = false;
        }




        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            MoveDownPanel.Visible = true;
            foreach(string item in items1)
            {
                if(item != "")
                {
                    MoveDownComboBox.Items.Add(item);
                }
            }
        }

        private void MoveDownOkButton_Click(object sender, EventArgs e)
        {
            //把他從原來的items1刪除，移到items2
            temp_store = items1[MoveDownComboBox.SelectedIndex];
            items1.RemoveAt(MoveDownComboBox.SelectedIndex);
            items2.Add(temp_store);

            //接下來可能要把items再寫回topic，再寫回檔案裡
            topic1 = "";
            topic2 = "";
            for (int i = 0; i < items1.Count; i++)
            {
                if (items1[i] != "") {
                    //如果他是最後一項，那後面就不要再加一個換行了
                    if (i == items1.Count - 1)
                        topic1 += items1[i] + "\n" + "***";
                    else
                        topic1 += items1[i] + "\n" + "***" + "\n";
                }
            }
            for (int i = 0; i < items2.Count; i++)
            {
                if (items2[i] != "")
                {
                    //如果他是最後一項，那後面就不要再加一個換行了
                    if (i == items2.Count - 1)
                        topic2 += items2[i] + "\n" + "***";
                    else
                        topic2 += items2[i] + "\n" + "***" + "\n";
                }
            }
            topic1.Trim();
            topic2.Trim();

            MessageBox.Show(topic1 + "\n" + "*****" + "\n" + topic2);

            using (StreamWriter file = new StreamWriter(@"C:\Users\周遠同\Desktop\ToDoList.txt"))
            {
                file.WriteLine(topic1);
                file.WriteLine("*****");
                file.WriteLine(topic2);
            }

            LoadText();

            MoveDownPanel.Visible = false;
            MoveDownComboBox.Items.Clear();
            MoveDownComboBox.Text = "";

        }

        private void MoveDownCancelButton_Click(object sender, EventArgs e)
        {
            MoveDownPanel.Visible = false;
            MoveDownComboBox.Items.Clear();
            MoveDownComboBox.Text = "";
        }




        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            MoveUpPanel.Visible = true;
            foreach (string item in items2)
            {
                if (item != "")
                {
                    MoveUpComboBox.Items.Add(item);
                }
            }
        }

        private void MoveUpOkButton_Click(object sender, EventArgs e)
        {
            //把他從原來的items2刪除，移到items1
            temp_store = items2[MoveUpComboBox.SelectedIndex];
            items2.RemoveAt(MoveUpComboBox.SelectedIndex);
            items1.Add(temp_store);

            //接下來可能要把items再寫回topic，再寫回檔案裡
            topic1 = "";
            topic2 = "";
            for (int i = 0; i < items1.Count; i++)
            {
                if (items1[i] != "")
                {
                    //如果他是最後一項，那後面就不要再加一個換行了
                    if (i == items1.Count - 1)
                        topic1 += items1[i] + "\n" + "***";
                    else
                        topic1 += items1[i] + "\n" + "***" + "\n";
                }
            }
            for (int i = 0; i < items2.Count; i++)
            {
                if (items2[i] != "")
                {
                    //如果他是最後一項，那後面就不要再加一個換行了
                    if (i == items2.Count - 1)
                        topic2 += items2[i] + "\n" + "***";
                    else
                        topic2 += items2[i] + "\n" + "***" + "\n";
                }
            }
            topic1.Trim();
            topic2.Trim();

            using (StreamWriter file = new StreamWriter(@"C:\Users\周遠同\Desktop\ToDoList.txt"))
            {
                file.WriteLine(topic1);
                file.WriteLine("*****");
                file.WriteLine(topic2);
            }
            LoadText();

            MoveUpPanel.Visible = false;
            MoveUpComboBox.Items.Clear();
            MoveUpComboBox.Text = "";
        }

        private void MoveUpCancelButton_Click(object sender, EventArgs e)
        {
            MoveUpPanel.Visible = false;
            MoveUpComboBox.Items.Clear();
            MoveUpComboBox.Text = "";
        }
    }
}
