using System.Windows.Forms;
using System.Drawing;

namespace StockViewer
{
    class TextData
    {
        public RichTextBox TextBox { get { return textBox; } }
        public float CordX { get { return cordX; } set {
                cordX = value;
                textBox.Location = new Point((int)cordX, textBox.Location.Y);
            } }

        RichTextBox textBox;
        float cordX = 0;

        public bool white;

        public TextData(RichTextBox textBox)
        {
            this.textBox = textBox;
        }

        public void Set_FontSize(int fontSize)
        {
            //Serif
            textBox.Font = new Font("Tw Cen MT", fontSize, FontStyle.Bold);
        }

        public void Set_Text(string text)
        {
            textBox.Text = text;
            Color_ProcentText();
        }

        public void Update_Poz(float movment)
        {
            cordX += movment;
            textBox.Location = new Point((int)cordX, textBox.Location.Y);
        }

        public void Update_Color(Color backColor)
        {
            white = !white;
            if (white)
            {
                textBox.BackColor = backColor;
                textBox.ForeColor = Color.White;
            }
            else
            {
                textBox.BackColor = backColor;
                textBox.ForeColor = Color.Black;
            }
            Color_ProcentText();
        }

        void Color_ProcentText()
        {
            var words = textBox.Text.Split();

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > 0 && words[i][0] == '(')
                {
                    if (words[i][1] == '-')
                    {
                        textBox.Select(textBox.Text.IndexOf(words[i]), words[i].Length);
                        textBox.SelectionColor = Color.Red;
                    }
                    else
                    {
                        textBox.Select(textBox.Text.IndexOf(words[i]), words[i].Length);
                        textBox.SelectionColor = Color.ForestGreen;
                    }
                }
            }
        }
    }
}
