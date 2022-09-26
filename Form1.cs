using System;
using System.Drawing;
using System.Windows.Forms;

namespace Safe
{
    public partial class Form1 : Form
    {
        private int cellSize;
        Button button;
        Button[,] buttons;
        private GameEngine gameEngine;       
        public Form1()
        {
            InitializeComponent();
            bReset.Enabled = false;
            bStop.Enabled = false;
        }
        private void InitButtons(sbyte[,] currentField)
        {
            byte fieldSize = gameEngine._fieldSize;
            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    buttons = new Button[fieldSize, fieldSize];
                    cellSize = splitContainer1.Panel2.Height / fieldSize;
                    button = new Button();
                    button.Location = new Point(i * cellSize, j * cellSize);
                    button.Size = new Size(cellSize, cellSize);
                    buttons[i, j] = button;
                    if (currentField[i, j] == -1)
                        button.BackColor = Color.Red;
                    else button.BackColor = Color.Green;
                    button.MouseUp += new MouseEventHandler(OnButtonPressedMouse);
                    splitContainer1.Panel2.Controls.Add(button);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e) { }
           
        private void bStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void StartGame() 
        {
            bStart.Enabled = false;
            nudFieldSize.Enabled = false;   
            bReset.Enabled = true;
            bStop.Enabled = true;
            gameEngine = new GameEngine(fieldSize: (byte)nudFieldSize.Value);
            sbyte[,] randomField = gameEngine.GetField();
            InitButtons(randomField);
        }
        private void bReset_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            bStart.Enabled = true;
            nudFieldSize.Enabled = true;
            StartGame();
        }                 
        private  void OnButtonPressedMouse(object sender, MouseEventArgs e)
        {
            Button pressedButton = sender as Button;
            ButtonPressed(pressedButton);                       
        }
        private void ButtonPressed(Button pressedButton)
        {            
            int yButton = pressedButton.Location.Y / cellSize;
            int xButton = pressedButton.Location.X / cellSize;
            gameEngine.SwitchValue(xIndex:xButton, yIndex:yButton); 
            splitContainer1.Panel2.Controls.Clear();
            InitButtons(gameEngine.GetField());
            if (gameEngine.IsFinished())
            {
                StopGame();
                MessageBox.Show("Safe has opened :)");
                
            }
        }                
        private void StopGame()
        {
            bStart.Enabled = true;
            nudFieldSize.Enabled = true;
            bReset.Enabled = false;           
            splitContainer1.Panel2.Controls.Clear();                       
        }
        private void bStop_Click(object sender, EventArgs e)
        {
            StopGame();
        }
    }

}
