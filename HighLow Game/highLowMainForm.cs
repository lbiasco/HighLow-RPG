using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HighLow_Game.Properties;

namespace HighLow_Game
{
    public partial class highLowMainForm : Form
    {
        
        // Declare global variables for round number, enemy health, the random number generation, and player default name
        int round = 1;
        string enemyHealthText = "100";
        Random randomGen = new Random();
        string playerName = "Player";

        string outputText = "";
        int timerIndex = 0;

        public highLowMainForm()
        {
            InitializeComponent();
        }

        // Load form from Designer code
        private void highLowMainForm_Load(object sender, EventArgs e)
        {
            // Introduce player to game
            MessageBox.Show("How to play:"
              + "\r\n\r\nYou roll two dice (by clicking 'Go!') that add to compete for a selected action"
              + "\r\n\r\nPower: Value used for actions" + "\r\n\r\nAttack: Directly hurt (or be hurt) by your power value"
              + "\r\n\r\nCritical: Try to get at least two times the enemy's rolls for a quadruple Attack"
              + "\r\n\r\nHeal: Get only more than half the enemy's rolls to recover HP equal to your power value (but you're susceptible to a Critical)", "High Low RPG");

            outputLabel.Text = "Welcome to High Low RPG, the simple dice RPG!";
            // Ask for player name and initial "health" and verify inputs
            name_Retrieval();
            playerNameLabel.Text = playerName + ":";

            health_Retrieval();
            enemyHealth.Maximum =  Convert.ToInt32(enemyHealthText);
            enemyHealth.Value = Convert.ToInt32(enemyHealthText);
            enemyHealthLabel.Text = enemyHealthText + " HP";
        }

        // Player name input verification
        public string name_Retrieval()
        {
            InputBoxValidation validation = delegate(string val)
            {
                if (val == "")
                {
                    return "You at least have a name!";
                }
                return "";
            };

            if (InputBoxVal.Show("What are you called?", "Name:", ref playerName, validation) == DialogResult.OK)
            {
                return playerName;
            }
            return playerName;
        }

        // Player health input verification
        public string health_Retrieval()
        {
            InputBoxValidation validation = delegate(string val)
            {
                double value;
                if (val == "" || val == "0")
                {
                    return "It has to be living...";
                }
                if (double.TryParse(val, out value) == false)
                {
                    return "I can't actually read.";
                }
                if (value < 0)
                {
                    return "Is that like mutilating the dead?";
                }
                if (value % 1 != 0)
                {
                    return "How is that supposed to work?";
                }
                return "";
            };

            if (InputBoxVal.Show("How strong will your enemy be?", "Enemy's Health:", ref enemyHealthText, validation) == DialogResult.OK)
            {
                return enemyHealthText;
            }
            return enemyHealthText;
        }

        // Roll button (Go!) code
        private void rollButton_Click(object sender, EventArgs e)
        {
            // Initialize the round
            outputText = "";
            outputLabel.Text = "";
            timerIndex = 0;

            backgroundPictureBox.Image = Resources.TransparentImage;

            // If no action was selected, run the code no further
            if (actionListBox.SelectedItem == null)
            {
                return;
            }

            // Duplicate player health value for later use
            double playerHealthValue = playerHealth.Value;

            // Test power input for validity
            if (powerTextBox.Text == "" || powerTextBox.Text == "0")
            {
                outputText = "No power, no action.";
                outputTimer.Start();
                return;
            }

            double power;
            if (!double.TryParse(powerTextBox.Text, out power))
            {
                outputText = "Sure, the pen is mightier than the sword. But not here.";
                outputTimer.Start();
                return;
            }

            if (power < 0)
            {
                outputText = "What do you think will happen when you do that?";
                outputTimer.Start();
                return;
            }
            if (power > playerHealthValue)
            {
                outputText = "You won't have enough HP...";
                outputTimer.Start();
                return;
            }
            if (power % 1 != 0)
            {
                outputText = "I don't know why this doesn't work; it just doesn't.";
                outputTimer.Start();
                return;
            }
            
            // Generate random dice rolls for house and player and apply to text boxes
            int enemyDie1 = randomGen.Next(1, 7);
            int enemyDie2 = randomGen.Next(1, 7);

            int enemyDiceTotal = enemyDie1 + enemyDie2;

            enemyRoll1TextBox.Text = enemyDie1.ToString();
            enemyRoll2TextBox.Text = enemyDie2.ToString();
            enemyRollTotalTextBox.Text = enemyDiceTotal.ToString();
            
            int playerDie1 = randomGen.Next(1, 7);
            int playerDie2 = randomGen.Next(1, 7);

            int playerDiceTotal = playerDie1 + playerDie2;

            playerRoll1TextBox.Text = playerDie1.ToString();
            playerRoll2TextBox.Text = playerDie2.ToString();
            playerRollTotalTextBox.Text = playerDiceTotal.ToString();
            string action = actionListBox.SelectedItem.ToString();

            // Define action code (to be selected from action list)

            /* If "Attack" is selected, compare player dice total to enemy dice total
             * If player wins, remove power input from enemy health
             * If enemy wins, remove power input from player health
             * If a tie, no effects */
            if (action == "Attack")
            {
                if (playerDiceTotal > enemyDiceTotal)
                {
                    backgroundPictureBox.Image = Resources.AttackImage1;
                    enemyHealth.Step = -Convert.ToInt32(power);
                    enemyHealth.PerformStep();
                    outputText = "You hit!";
                    outputTimer.Start();
                }
                else if (playerDiceTotal < enemyDiceTotal)
                {
                    backgroundPictureBox.Image = Resources.AttackImage2;
                    playerHealth.Step = -Convert.ToInt32(power);
                    playerHealth.PerformStep();
                    outputText = "You were hit!";
                    outputTimer.Start();
                }
                else
                {
                    backgroundPictureBox.Image = Resources.TieImage1;
                    outputText = "It was an even clash!";
                    outputTimer.Start();
                }
            }
            /* If "Critical" is selected, compare player dice total to two times enemy dice total
             * If player wins (or a tie), remove three times power input from enemy health
             * If enemy wins, remove power input from player health*/
            if (action == "Critical")
            {
                if (playerDiceTotal >= enemyDiceTotal * 2)
                {
                    backgroundPictureBox.Image = Resources.CriticalImage1;
                    enemyHealth.Step = -Convert.ToInt32(power) * 3;
                    enemyHealth.PerformStep();
                    outputText = "Critical hit!";
                    outputTimer.Start();
                }
                if (playerDiceTotal < enemyDiceTotal * 2)
                {
                    backgroundPictureBox.Image = Resources.AttackImage2;
                    playerHealth.Step = -Convert.ToInt32(power);
                    playerHealth.PerformStep();
                    outputText = "You were hit!";
                    outputTimer.Start();
                }
            }
            /* If "Heal" is selected, compare player dice total to half enemy dice total
             * If player wins, add power input to player health
             * If enemy wins (or a tie), remove three times power input from player health */
            if (action == "Heal")
            {
                if (playerDiceTotal > enemyDiceTotal / 2)
                {
                    backgroundPictureBox.Image = Resources.HealImage1;
                    playerHealth.Step = Convert.ToInt32(power);
                    playerHealth.PerformStep();
                    outputText = "Successfully healed!";
                    outputTimer.Start();
                }
                if (playerDiceTotal <= enemyDiceTotal / 2)
                {
                    backgroundPictureBox.Image = Resources.CriticalImage2;
                    playerHealth.Step = -Convert.ToInt32(power) * 3;
                    playerHealth.PerformStep();
                    outputText = "You were hit with defenses down!";
                    outputTimer.Start();
                }
            }

            // Update player and enemy health labels
            playerHealthLabel.Text = playerHealth.Value.ToString() + " HP";
            enemyHealthLabel.Text = enemyHealth.Value.ToString() + " HP";

            // Check if either player or enemy have zero health, and if so, end the game
            if (playerHealth.Value == 0)
            {
                DialogResult answer = MessageBox.Show("Are you gonna quit?", "You're dead.", MessageBoxButtons.YesNo);
                string answer2 = answer.ToString();
                if (answer2 == "No")
                {
                    outputText = "";
                    outputLabel.Text = "";
                    timerIndex = 0;

                    outputText = "Welcome back!";
                    outputTimer.Start();
                    playerRoll1TextBox.Text = "";
                    playerRoll2TextBox.Text = "";
                    playerRollTotalTextBox.Text = "";
                    enemyRoll1TextBox.Text = "";
                    enemyRoll2TextBox.Text = "";
                    enemyRollTotalTextBox.Text = "";
                    powerTextBox.Text = "";

                    health_Retrieval();
                    enemyHealth.Maximum = Convert.ToInt32(enemyHealthText);
                    enemyHealth.Value = Convert.ToInt32(enemyHealthText);
                    enemyHealthLabel.Text = enemyHealthText + " HP";

                    playerHealth.Value = 100;
                    playerHealthLabel.Text = "100 HP";
                    return;
                }
                else
                {
                    Application.Exit();
                }
            }

            if (enemyHealth.Value == 0)
            {
                DialogResult answer = MessageBox.Show("Wanna fight again?", "You've won the battle!", MessageBoxButtons.YesNo);
                string answer3 = answer.ToString();
                if (answer3 == "Yes")
                {
                    outputText = "";
                    outputLabel.Text = "";
                    timerIndex = 0;

                    outputText = "Welcome back!";
                    outputTimer.Start();
                    playerRoll1TextBox.Text = "";
                    playerRoll2TextBox.Text = "";
                    playerRollTotalTextBox.Text = "";
                    enemyRoll1TextBox.Text = "";
                    enemyRoll2TextBox.Text = "";
                    enemyRollTotalTextBox.Text = "";
                    powerTextBox.Text = "";

                    health_Retrieval();
                    enemyHealth.Maximum = Convert.ToInt32(enemyHealthText);
                    enemyHealth.Value = Convert.ToInt32(enemyHealthText);
                    enemyHealthLabel.Text = enemyHealthText + " HP";

                    playerHealth.Value = 100;
                    playerHealthLabel.Text = "100 HP";
                    return;
                }
                else
                {
                    Application.Exit();
                }
            }

            // Update round number
            round++;
            roundLabel.Text = "Round " + round;
        }

        // Used for RPG-like paced text output
        private void outputTimer_Tick(object sender, EventArgs e)
        {

            if (timerIndex <= outputText.Length - 1)
            {
                outputLabel.Text = outputLabel.Text + outputText[timerIndex];
                timerIndex++;
            }
            
        }
    }
}