using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HangmanLib;

namespace HangmanWinForm
{
    public partial class FrmNewGame : Form
    {
        Hangman newGame;

        private List<Label> blanks;
        private int stickmanImgIndex;
        private List<Image> stickmanImgs;

        public FrmNewGame()
        {
            InitializeComponent();
        }

        private void FrmNewGame_Load(object sender, EventArgs e)
        {
            InitializeValues();
            GenerateLabelsAndButtons();
            LoadImages();
        }

        private void Button_Click(object sender, EventArgs eventArgs)
        {
            CustomControls.RJButton btn = (CustomControls.RJButton)sender;

            switch (btn.Name)
            {
                case "btnBack":
                    if (MessageBoxWithDialogResult("Are you sure you want to go back?") == DialogResult.Yes)
                    {
                        this.Hide();
                        Form frmMainMenu = new FrmMainMenu();
                        frmMainMenu.ShowDialog();
                        this.Close();
                    }
                    return;
                case "btnRestart":
                    if (MessageBoxWithDialogResult("Are you sure you want to start a new game?") == DialogResult.Yes)
                    {
                        StartNewGame();
                    }
                    break;
                case "btnUseHint":
                    ClickRandomCorrectLetterButton();
                    lblWordHint.Text = $"HINT: {newGame.ChosenWord.WordsHint}";
                    if (newGame.GameOver == true)
                    {
                        DisplayGameoverMessage();
                    }
                    btn.Enabled = false;
                    return;
            }
        }

        private void InitializeValues()
        {
            newGame = Hangman.GetHangman;
            if (!newGame.File.WordExistInAnyTopic())
            {
                DialogResult result = MessageBox.Show("There are no word! Please add words in setting!", "Word does not exist",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    Form frmSetting = new FrmSetting();
                    frmSetting.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    Form frmMainMenu = new FrmMainMenu();
                    frmMainMenu.ShowDialog();
                    this.Close();
                }
            }
            stickmanImgIndex = 0;
            blanks = new List<Label>(newGame.ChosenWord.WordName.Length);
            lblWordHint.Text = "";
            btnUseHint.Enabled = true;
        }

        private void GenerateLabelsAndButtons()
        {
            flowPanelBlanks.Controls.Clear();
            flowPanelButtons.Controls.Clear();

            // center blanks in flowLayoutPanel (each label use 40 Width)
            flowPanelBlanks.Width = 46 * blanks.Capacity;
            flowPanelBlanks.Dock = DockStyle.Fill;
            flowPanelBlanks.Anchor = AnchorStyles.None;

            // generate label depend on word length to flowLayoutPanel
            for (int i = 0; i < blanks.Capacity; i++)
            {
                Label labelBlank = new Label
                {
                    Text = "_",
                    Name = $"blank{i}",
                    Size = new Size(40, 50),
                    ForeColor = Color.Black
                };
                blanks.Add(labelBlank);
                flowPanelBlanks.Controls.Add(labelBlank);
            }

            // generate letter button depend on word length + 7 to flowLayoutPenel
            string scrambledLetters = newGame.GetScrambledLetterOfChosenWord();
            int tabIndex = btnUseHint.TabIndex;
            for (int i = 0; i < scrambledLetters.Length; i++)
            {
                CustomControls.RJButton btnLetter = new CustomControls.RJButton
                {
                    Name = $"btn{scrambledLetters[i]}",
                    Text = $"{scrambledLetters[i]}",
                    Size = new Size(94, 80),
                    Cursor = Cursors.Hand,
                    TabIndex = ++tabIndex,
                    BorderRadius = 10,
                    BackColor = Color.MediumPurple
                };
                btnLetter.Click += LetterButton_Click;
                flowPanelButtons.Controls.Add(btnLetter);
            }
        }

        private void LetterButton_Click(object sender, EventArgs e)
        {
            CustomControls.RJButton btn = (CustomControls.RJButton)sender;
            if (newGame.GuessLetterInChosenWord(btn.Text, out int lIndex) == true)
            {
                blanks[lIndex].Text = btn.Text;
                btn.Enabled = false;
            }
            else
            {
                if (stickmanImgIndex < 6)
                {
                    pbStickman.Image = stickmanImgs[++stickmanImgIndex];
                }
            }

            newGame.CheckConditionsOfGameOver();

            if (newGame.GameOver == true)
            {
                DisplayGameoverMessage();
            }
        }

        private void LoadImages()
        {
            stickmanImgs = new List<Image>
            {
                Image.FromFile(Path.Combine(Environment.CurrentDirectory,"Resources/stand.png")),
                Image.FromFile(Path.Combine(Environment.CurrentDirectory,"Resources/head.png")),
                Image.FromFile(Path.Combine(Environment.CurrentDirectory,"Resources/body.png")),
                Image.FromFile(Path.Combine(Environment.CurrentDirectory,"Resources/left_arm.png")),
                Image.FromFile(Path.Combine(Environment.CurrentDirectory,"Resources/right_arm.png")),
                Image.FromFile(Path.Combine(Environment.CurrentDirectory,"Resources/left_leg.png")),
                Image.FromFile(Path.Combine(Environment.CurrentDirectory,"Resources/right_leg.png"))
            };
            pbStickman.Image = stickmanImgs[stickmanImgIndex];
        }

        private void StartNewGame()
        {
            newGame.StartNewGame();
            InitializeValues();
            GenerateLabelsAndButtons();
            stickmanImgIndex = 0;
            pbStickman.Image = stickmanImgs[stickmanImgIndex];
        }

        private void DisplayGameoverMessage()
        {
            DialogResult result;
            if (newGame.MistakeCount == 6)
            {
                result = MessageBox.Show("You Fucking Suck LOL!!!! Wanna go again?",
                    "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }
            else
            {
                result = MessageBox.Show("Congratulation You Won! Wanna go again?",
                    "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

            if (result == DialogResult.Yes)
            {
                StartNewGame();
            }
            else
            {
                this.Hide();
                Form frmMainMenu = new FrmMainMenu();
                frmMainMenu.ShowDialog();
                this.Close();
            }
        }

        private void ClickRandomCorrectLetterButton()
        {
            (int index, string letter) = newGame.GetUnguessedLetterFromChosenWord();
            
            // loop all letterButtons, if letterButton.Text equal letter
            // disable that button and show the correct letter by blanks[index].Text == letter
            foreach (CustomControls.RJButton btn in flowPanelButtons.Controls.OfType<CustomControls.RJButton>())
            {
                if (btn.Enabled == true)
                {
                    if (btn.Text == letter)
                    {
                        btn.Enabled = false;
                        blanks[index].Text = letter;

                        if (stickmanImgIndex < 6)
                        {
                            pbStickman.Image = stickmanImgs[++stickmanImgIndex];
                        }

                        return;
                    }
                }
            }
        }

        private DialogResult MessageBoxWithDialogResult(string str)
        {
            return MessageBox.Show($"Game is still in progress. {str}", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void FrmNewGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBoxWithDialogResult("Are you sure you want to exit?");
            if (result == DialogResult.Yes)
            {
                this.Dispose();
                Environment.Exit(0);
            }
        }

        #region Tool
        private void Diagnosing<T>(IEnumerable<T> list)
        {
            StringBuilder listStr;
            if (list.GetType().Equals(typeof(List<Topic>)))
            {
                listStr = new StringBuilder("Topics in details:\n");
                foreach (Topic t in (List<Topic>)list)
                {
                    listStr.AppendLine($"tIndex: {t.TopicIndex}, tName: {t.TopicName}");
                }
            }
            else
            {
                listStr = new StringBuilder("Words in details:\n");
                foreach (Word w in (List<Word>)list)
                {
                    listStr.AppendLine($"tIndex: {w.TopicIndex}, tName: {w.WordName}");
                }
            }

            MessageBox.Show(listStr.ToString());
        }
        #endregion
    }
}
