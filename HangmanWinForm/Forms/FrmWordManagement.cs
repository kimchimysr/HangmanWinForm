using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using HangmanLib;

namespace HangmanWinForm
{
    public partial class FrmWordManagement : Form
    {
        private Data file;
        private int tIndex = 0;

        public FrmWordManagement()
        {
            InitializeComponent();
        }

        private void FrmWordManagement_Load(object sender, EventArgs e)
        {
            LoadFromFiles();
            FillListBox(lbTopicList, file.GetTopics());
            DisableAllButtonsAndTextBoxs();
        }

        private void LoadFromFiles()
        {
            file = Data.GetData;
            file.Load();
        }

        private void DisableAllButtonsAndTextBoxs()
        {
            btnAddTopic.Enabled = false;
            btnAddWord.Enabled = false;
            btnAddHint.Enabled = false;
            btnRemoveHint.Enabled = false;
            btnRemoveTopic.Enabled = false;
            btnRemoveWord.Enabled = false;
            txtNewWord.Enabled = false;
            txtNewHint.Enabled = false;
            txtNewHint2.Enabled = false;
        }

        private void FillListBox<T>(ListBox lb, IEnumerable<T> list, int tIndex = -1)
        {
            lb.Items.Clear();

            if (list.GetType() == typeof(List<Topic>))
            {
                if (((List<Topic>)list).Count > 0)
                {
                    foreach (var item in (List<Topic>)list)
                    {
                        lb.Items.Add(item.TopicName);
                        this.tIndex = item.TopicIndex + 1;
                    }
                }
            }
            else if (list.GetType() == typeof(List<Word>))
            {
                if (((List<Word>)list).Count > 0)
                {
                    foreach (Word item in (List<Word>)list)
                    {
                        if (item.TopicIndex == tIndex)
                        {
                            lb.Items.Add(item.WordName);
                        }
                    }
                }
            }
        }

        private void FillTopicsToComboBox(ComboBox cb)
        {
            cb.Items.Clear();

            if (file.GetTopics().Count > 0)
            {
                foreach (var item in file.GetTopics())
                {
                    cb.Items.Add(item.TopicName);
                }
            }
        }

        private void tcManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tcManagement.SelectedIndex;

            switch (index)
            {
                case 1:
                    FillTopicsToComboBox(cbTopicList);
                    lbWordList.Items.Clear();
                    txtSelectedWord.Text = "";
                    return;
                case 2:
                    FillTopicsToComboBox(cbTopicList2);
                    lbWordList2.Items.Clear();
                    txtSelectedWord2.Text = "";
                    txtCurrentHint.Text = "";
                    return;
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            switch (cb.Name)
            {
                case "cbTopicList":
                    if (cb.SelectedIndex != -1)
                    {
                        FillListBox(lbWordList, file.GetWords(), cb.SelectedIndex);
                        txtNewWord.Enabled = true;
                        txtNewHint.Enabled = true;
                        txtSelectedWord.Text = "";
                    }
                    return;
                case "cbTopicList2":
                    if (cb.SelectedIndex != -1)
                    {
                        FillListBox(lbWordList2, file.GetWords(), cb.SelectedIndex);
                        txtNewHint2.Enabled = false;
                        txtSelectedWord2.Text = "";
                        txtCurrentHint.Text = "";
                    }
                    return;
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;

            switch (lb.Name)
            {
                case "lbTopicList":
                    if (lb.SelectedIndex >= 0)
                    {
                        txtSelectedTopic.Text = lb.SelectedItem.ToString();
                    }
                    break;
                case "lbWordList":
                    if (lb.SelectedIndex >= 0)
                    {
                        txtSelectedWord.Text = lb.SelectedItem.ToString();
                    }
                    break;
                case "lbWordList2":
                    if (lb.SelectedIndex >= 0)
                    {
                        txtSelectedWord2.Text = lb.SelectedItem.ToString();
                        txtCurrentHint.Text = file.GetWord(lb.SelectedItem.ToString()).WordsHint;
                    }
                    break;
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            switch (tb.Name)
            {
                case "txtNewTopic":
                    if (tb.Text.Length > 0)
                    {
                        btnAddTopic.Enabled = true;
                    }
                    else
                    {
                        btnAddTopic.Enabled = false;
                    }
                    return;
                case "txtNewWord":
                    if (tb.Text.Length >= 6 && tb.Text.Length <= 14)
                    {
                        btnAddWord.Enabled = true;
                    }
                    else
                    {
                        btnAddWord.Enabled = false;
                    }
                    return;
                case "txtNewHint2":
                    if (tb.Text.Length > 0)
                    {
                        btnAddHint.Enabled = true;
                    }
                    else
                    {
                        btnAddHint.Enabled = false;
                    }
                    return;
                case "txtSelectedTopic":
                    if (tb.Text.Length > 0)
                    {
                        btnRemoveTopic.Enabled = true;
                    }
                    else
                    {
                        btnRemoveTopic.Enabled = false;
                    }
                    return;
                case "txtSelectedWord":
                    if (tb.Text.Length > 0)
                    {
                        btnRemoveWord.Enabled = true;
                    }
                    else
                    {
                        btnRemoveWord.Enabled = false;
                    }
                    return;
                case "txtSelectedWord2":
                    if (tb.Text.Length > 0)
                    {
                        txtNewHint2.Enabled = true;
                    }
                    else
                    {
                        txtNewHint2.Enabled = false;
                    }
                    return;
                case "txtSelectedHint":
                    if (tb.Text.Length > 0)
                    {
                        btnRemoveHint.Enabled = true;
                    }
                    else
                    {
                        btnRemoveHint.Enabled = false;
                    }
                    return;
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox stb = (TextBox)sender;

            switch (stb.Name)
            {
                case "txtSearchTopic":
                    if (stb.Text.Length > 0)
                    {
                        if (lbTopicList.FindString(stb.Text) >= 0)
                        {
                            lbTopicList.SelectedIndex = lbTopicList.FindString(stb.Text);
                        }
                    }
                    else
                    {
                        lbTopicList.SelectedIndex = -1;
                    }
                    break;
                case "txtSearchWord":
                    if (stb.Text.Length > 0)
                    {
                        if (lbWordList.FindString(stb.Text) >= 0)
                        {
                            lbWordList.SelectedIndex = lbWordList.FindString(stb.Text);
                        }
                    }
                    else
                    {
                        lbWordList.SelectedIndex = -1;
                    }
                    break;
                case "txtSearchWord2":
                    if (stb.Text.Length > 0)
                    {
                        if (lbWordList2.FindString(stb.Text) >= 0)
                        {
                            lbWordList2.SelectedIndex = lbWordList2.FindString(stb.Text);
                        }
                    }
                    else
                    {
                        lbWordList2.SelectedIndex = -1;
                    }
                    break;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            CustomControls.RJButton btn = (CustomControls.RJButton)sender;

            switch (btn.Name)
            {
                case "btnAddTopic":
                    AddFunctions(btn.Name, txtNewTopic);
                    btn.Enabled = false;
                    return;
                case "btnAddWord":
                    AddFunctions(btn.Name, txtNewWord);
                    btn.Enabled = false;
                    return;
                case "btnAddHint":
                    AddFunctions(btn.Name, txtNewHint2);
                    FillListBox(lbWordList2, file.GetWords());
                    btn.Enabled = false;
                    return;
                case "btnRemoveTopic":
                    if (file.WordExistInTopic(lbTopicList.SelectedIndex) == true)
                    {
                        DialogResult result = MessageBox.Show("Removing this topic will also remove all the words inside! Remove Anyway?",
                            "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            file.RemoveTopicAt(lbTopicList.SelectedIndex);
                            file.Save();
                            FillListBox(lbTopicList, file.GetTopics());
                            txtSelectedTopic.Text = "";
                            btn.Enabled = false;
                        }
                    }
                    else
                    {
                        file.RemoveTopicAt(lbTopicList.SelectedIndex);
                        file.Save();
                        FillListBox(lbTopicList, file.GetTopics());
                        txtSelectedTopic.Text = "";
                        btn.Enabled = false;
                    }
                    return;
                case "btnRemoveWord":
                    file.RemoveWord(lbWordList.SelectedItem.ToString());
                    file.Save();
                    FillListBox(lbWordList, file.GetWords());
                    txtSelectedWord.Text = "";
                    btn.Enabled = false;
                    return;
                case "btnRemoveHint":
                    file.RemoveHint(cbTopicList2.SelectedIndex, lbWordList2.SelectedItem.ToString());
                    file.Save();
                    FillListBox(lbWordList2, file.GetWords());
                    txtCurrentHint.Text = "";
                    btn.Enabled = false;
                    return;
            }
        }

        private void AddFunctions(string btnName, TextBox txt)
        {
            switch (btnName)
            {
                case "btnAddTopic":
                    if (!lbTopicList.Items.Contains(txt.Text))
                    {
                        // avoid copy and paste into textbox
                        if (!txt.Text.Any(x => !char.IsLetter(x)))
                        {
                            file.AddTopic(tIndex++, txt.Text);
                            file.Save();
                            FillListBox(lbTopicList, file.GetTopics());
                            lbTopicList.SelectedItem = txt.Text;
                            txt.Text = "";
                            txt.Focus();
                        }
                    }
                    else
                    {
                        ShowDuplicatedMessage("Topic");
                        txtNewTopic.Text = "";
                    }
                    break;
                case "btnAddWord":
                    if (!file.WordExist(txt.Text))
                    {
                        // avoid copy and paste into textbox
                        if (!txt.Text.Any(x => !char.IsLetter(x)))
                        {
                            if (txtNewHint.Text != "")
                            {
                                file.AddWord(cbTopicList.SelectedIndex, txt.Text, txtNewHint.Text);
                                file.Save();
                                FillListBox(lbWordList, file.GetWords(), file.GetTopicAt(cbTopicList.SelectedIndex).TopicIndex);
                                lbWordList.SelectedItem = txt.Text;
                                txt.Text = "";
                                txtNewHint.Text = "";
                                txt.Focus();
                            }
                            else
                            {
                                file.AddWord(cbTopicList.SelectedIndex, txt.Text);
                                file.Save();
                                FillListBox(lbWordList, file.GetWords(), file.GetTopicAt(cbTopicList.SelectedIndex).TopicIndex);
                                lbWordList.SelectedItem = txt.Text;
                                txt.Text = "";
                                txtNewHint.Text = "";
                                txt.Focus();
                            } 
                        }
                    }
                    else
                    {
                        ShowDuplicatedMessage("Word");
                        txtNewWord.Text = "";
                        txt.Focus();
                    }
                    break;
                case "btnAddHint":
                    file.AddHint(file.GetTopicAt(cbTopicList2.SelectedIndex).TopicIndex, lbWordList2.SelectedItem.ToString(), txt.Text);
                    file.Save();
                    txt.Text = "";
                    txt.Focus();
                    break;
            }
        }

        private void FrmWordManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void ShowDuplicatedMessage(string msg)
        {
            MessageBox.Show($"{msg} is already exist! Please add another {msg}.", "Duplicated Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}