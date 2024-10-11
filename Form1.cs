using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ultimate_TicTacToe
{
    public partial class Form1 : Form
    {
        bool playerX = true; // checks if it's Player x turn

        short activeField = 10; // sets the field aktive (count == field; 10 == all fields)
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            playerX = true;

            activeField = 10;

            // Buttons from Field 1
            btn_1_1.Text = "";
            btn_1_2.Text = "";
            btn_1_3.Text = "";
            btn_1_4.Text = "";
            btn_1_5.Text = "";
            btn_1_6.Text = "";
            btn_1_7.Text = "";
            btn_1_8.Text = "";
            btn_1_9.Text = "";
            //Buttons from Field 2
            btn_2_1.Text = "";
            btn_2_2.Text = "";
            btn_2_3.Text = "";
            btn_2_4.Text = "";
            btn_2_5.Text = "";
            btn_2_6.Text = "";
            btn_2_7.Text = "";
            btn_2_8.Text = "";
            btn_2_9.Text = "";
            //Buttons from Field 3
            btn_3_1.Text = "";
            btn_3_2.Text = "";
            btn_3_3.Text = "";
            btn_3_4.Text = "";
            btn_3_5.Text = "";
            btn_3_6.Text = "";
            btn_3_7.Text = "";
            btn_3_8.Text = "";
            btn_3_9.Text = "";
            //Buttons from Field 4
            btn_4_1.Text = "";
            btn_4_2.Text = "";
            btn_4_3.Text = "";
            btn_4_4.Text = "";
            btn_4_5.Text = "";
            btn_4_6.Text = "";
            btn_4_7.Text = "";
            btn_4_8.Text = "";
            btn_4_9.Text = "";
            //Buttons from Field 5
            btn_5_1.Text = "";
            btn_5_2.Text = "";
            btn_5_3.Text = "";
            btn_5_4.Text = "";
            btn_5_5.Text = "";
            btn_5_6.Text = "";
            btn_5_7.Text = "";
            btn_5_8.Text = "";
            btn_5_9.Text = "";
            //Buttons from Field 6
            btn_6_1.Text = "";
            btn_6_2.Text = "";
            btn_6_3.Text = "";
            btn_6_4.Text = "";
            btn_6_5.Text = "";
            btn_6_6.Text = "";
            btn_6_7.Text = "";
            btn_6_8.Text = "";
            btn_6_9.Text = "";
            //Buttons from Field 7
            btn_7_1.Text = "";
            btn_7_2.Text = "";
            btn_7_3.Text = "";
            btn_7_4.Text = "";
            btn_7_5.Text = "";
            btn_7_6.Text = "";
            btn_7_7.Text = "";
            btn_7_8.Text = "";
            btn_7_9.Text = "";
            //Buttons from Field 8
            btn_8_1.Text = "";
            btn_8_2.Text = "";
            btn_8_3.Text = "";
            btn_8_4.Text = "";
            btn_8_5.Text = "";
            btn_8_6.Text = "";
            btn_8_7.Text = "";
            btn_8_8.Text = "";
            btn_8_9.Text = "";
            //Buttons from Field 9
            btn_9_1.Text = "";
            btn_9_2.Text = "";
            btn_9_3.Text = "";
            btn_9_4.Text = "";
            btn_9_5.Text = "";
            btn_9_6.Text = "";
            btn_9_7.Text = "";
            btn_9_8.Text = "";
            btn_9_9.Text = "";

            // Reset Colors
            reset_colors();

            // Reset FieldButtons
            btn_field1.Visible = false;
            btn_field2.Visible = false;
            btn_field3.Visible = false;
            btn_field4.Visible = false;
            btn_field5.Visible = false;
            btn_field6.Visible = false;
            btn_field7.Visible = false;
            btn_field8.Visible = false;
            btn_field9.Visible = false;

            // activate fields
            disable_or_activate_field(10, btn_visability: true); // set visavility for all buttons to True

            // reset label winner (lbl_winner)
            lbl_winner.Text = "";
            lbl_winner.ForeColor = Color.LimeGreen;
        }

        private void btn_how_to_play_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The first Player chooses a random Field, then the Colors show you where you can play next in. \nFor Example if i put a X in the center Field in the left top corner, Player O has to play in the top left Field.");
        }

        private void reset_colors()
        {
            btn_1_1.BackColor = Color.Gainsboro;
            btn_1_2.BackColor = Color.Gainsboro;
            btn_1_3.BackColor = Color.Gainsboro;
            btn_1_4.BackColor = Color.Gainsboro;
            btn_1_5.BackColor = Color.Gainsboro;
            btn_1_6.BackColor = Color.Gainsboro;
            btn_1_7.BackColor = Color.Gainsboro;
            btn_1_8.BackColor = Color.Gainsboro;
            btn_1_9.BackColor = Color.Gainsboro;
            btn_2_1.BackColor = Color.Gainsboro;
            btn_2_2.BackColor = Color.Gainsboro;
            btn_2_3.BackColor = Color.Gainsboro;
            btn_2_4.BackColor = Color.Gainsboro;
            btn_2_5.BackColor = Color.Gainsboro;
            btn_2_6.BackColor = Color.Gainsboro;
            btn_2_7.BackColor = Color.Gainsboro;
            btn_2_8.BackColor = Color.Gainsboro;
            btn_2_9.BackColor = Color.Gainsboro;
            btn_3_1.BackColor = Color.Gainsboro;
            btn_3_2.BackColor = Color.Gainsboro;
            btn_3_3.BackColor = Color.Gainsboro;
            btn_3_4.BackColor = Color.Gainsboro;
            btn_3_5.BackColor = Color.Gainsboro;
            btn_3_6.BackColor = Color.Gainsboro;
            btn_3_7.BackColor = Color.Gainsboro;
            btn_3_8.BackColor = Color.Gainsboro;
            btn_3_9.BackColor = Color.Gainsboro;
            btn_4_1.BackColor = Color.Gainsboro;
            btn_4_2.BackColor = Color.Gainsboro;
            btn_4_3.BackColor = Color.Gainsboro;
            btn_4_4.BackColor = Color.Gainsboro;
            btn_4_5.BackColor = Color.Gainsboro;
            btn_4_6.BackColor = Color.Gainsboro;
            btn_4_7.BackColor = Color.Gainsboro;
            btn_4_8.BackColor = Color.Gainsboro;
            btn_4_9.BackColor = Color.Gainsboro;
            btn_5_1.BackColor = Color.Gainsboro;
            btn_5_2.BackColor = Color.Gainsboro;
            btn_5_3.BackColor = Color.Gainsboro;
            btn_5_4.BackColor = Color.Gainsboro;
            btn_5_5.BackColor = Color.Gainsboro;
            btn_5_6.BackColor = Color.Gainsboro;
            btn_5_7.BackColor = Color.Gainsboro;
            btn_5_8.BackColor = Color.Gainsboro;
            btn_5_9.BackColor = Color.Gainsboro;
            btn_6_1.BackColor = Color.Gainsboro;
            btn_6_2.BackColor = Color.Gainsboro;
            btn_6_3.BackColor = Color.Gainsboro;
            btn_6_4.BackColor = Color.Gainsboro;
            btn_6_5.BackColor = Color.Gainsboro;
            btn_6_6.BackColor = Color.Gainsboro;
            btn_6_7.BackColor = Color.Gainsboro;
            btn_6_8.BackColor = Color.Gainsboro;
            btn_6_9.BackColor = Color.Gainsboro;
            btn_7_1.BackColor = Color.Gainsboro;
            btn_7_2.BackColor = Color.Gainsboro;
            btn_7_3.BackColor = Color.Gainsboro;
            btn_7_4.BackColor = Color.Gainsboro;
            btn_7_5.BackColor = Color.Gainsboro;
            btn_7_6.BackColor = Color.Gainsboro;
            btn_7_7.BackColor = Color.Gainsboro;
            btn_7_8.BackColor = Color.Gainsboro;
            btn_7_9.BackColor = Color.Gainsboro;
            btn_8_1.BackColor = Color.Gainsboro;
            btn_8_2.BackColor = Color.Gainsboro;
            btn_8_3.BackColor = Color.Gainsboro;
            btn_8_4.BackColor = Color.Gainsboro;
            btn_8_5.BackColor = Color.Gainsboro;
            btn_8_6.BackColor = Color.Gainsboro;
            btn_8_7.BackColor = Color.Gainsboro;
            btn_8_8.BackColor = Color.Gainsboro;
            btn_8_9.BackColor = Color.Gainsboro;
            btn_9_1.BackColor = Color.Gainsboro;
            btn_9_2.BackColor = Color.Gainsboro;
            btn_9_3.BackColor = Color.Gainsboro;
            btn_9_4.BackColor = Color.Gainsboro;
            btn_9_5.BackColor = Color.Gainsboro;
            btn_9_6.BackColor = Color.Gainsboro;
            btn_9_7.BackColor = Color.Gainsboro;
            btn_9_8.BackColor = Color.Gainsboro;
            btn_9_9.BackColor = Color.Gainsboro;
        }

        private void next_turn(int nextField)
        {   
            if (activeField == 0) { return; }

            reset_colors();
            if ((nextField == 1 && btn_field1.Visible) || (nextField == 2 && btn_field2.Visible) || (nextField == 3 && btn_field3.Visible) || (nextField == 4 && btn_field4.Visible) || (nextField == 5 && btn_field5.Visible) || (nextField == 6 && btn_field6.Visible) || (nextField == 7 && btn_field7.Visible) || (nextField == 8 && btn_field8.Visible) || (nextField == 9 && btn_field9.Visible)) // check if field is solved already
            {
                nextField = 10;
            }

            playerX = !playerX;

            if (nextField == 1 || nextField == 10)
            {
                if (activeField != 10) { activeField = 1; }
                btn_1_1.BackColor = Color.LimeGreen;
                btn_1_2.BackColor = Color.LimeGreen;
                btn_1_3.BackColor = Color.LimeGreen;
                btn_1_4.BackColor = Color.LimeGreen;
                btn_1_5.BackColor = Color.LimeGreen;
                btn_1_6.BackColor = Color.LimeGreen;
                btn_1_7.BackColor = Color.LimeGreen;
                btn_1_8.BackColor = Color.LimeGreen;
                btn_1_9.BackColor = Color.LimeGreen;
            }

            if (nextField == 2 || nextField == 10) {
                if (activeField != 10) { activeField = 2; }
                btn_2_1.BackColor = Color.LimeGreen;
                btn_2_2.BackColor = Color.LimeGreen;
                btn_2_3.BackColor = Color.LimeGreen;
                btn_2_4.BackColor = Color.LimeGreen;
                btn_2_5.BackColor = Color.LimeGreen;
                btn_2_6.BackColor = Color.LimeGreen;
                btn_2_7.BackColor = Color.LimeGreen;
                btn_2_8.BackColor = Color.LimeGreen;
                btn_2_9.BackColor = Color.LimeGreen;
            }

            if (nextField == 3 || nextField == 10) {
                if (activeField != 10) { activeField = 3; }
                btn_3_1.BackColor = Color.LimeGreen;
                btn_3_2.BackColor = Color.LimeGreen;
                btn_3_3.BackColor = Color.LimeGreen;
                btn_3_4.BackColor = Color.LimeGreen;
                btn_3_5.BackColor = Color.LimeGreen;
                btn_3_6.BackColor = Color.LimeGreen;
                btn_3_7.BackColor = Color.LimeGreen;
                btn_3_8.BackColor = Color.LimeGreen;
                btn_3_9.BackColor = Color.LimeGreen;

            }

            if (nextField == 4 || nextField == 10) {
                if (activeField != 10) { activeField = 4; }
                btn_4_1.BackColor = Color.LimeGreen;
                btn_4_2.BackColor = Color.LimeGreen;
                btn_4_3.BackColor = Color.LimeGreen;
                btn_4_4.BackColor = Color.LimeGreen;
                btn_4_5.BackColor = Color.LimeGreen;
                btn_4_6.BackColor = Color.LimeGreen;
                btn_4_7.BackColor = Color.LimeGreen;
                btn_4_8.BackColor = Color.LimeGreen;
                btn_4_9.BackColor = Color.LimeGreen;

            }

            if (nextField == 5 || nextField == 10) {
                if (activeField != 10) { activeField = 5; }
                btn_5_1.BackColor = Color.LimeGreen;
                btn_5_2.BackColor = Color.LimeGreen;
                btn_5_3.BackColor = Color.LimeGreen;
                btn_5_4.BackColor = Color.LimeGreen;
                btn_5_5.BackColor = Color.LimeGreen;
                btn_5_6.BackColor = Color.LimeGreen;
                btn_5_7.BackColor = Color.LimeGreen;
                btn_5_8.BackColor = Color.LimeGreen;
                btn_5_9.BackColor = Color.LimeGreen;
            }

            if (nextField == 6 || nextField == 10) {
                if (activeField != 10) { activeField = 6; }
                btn_6_1.BackColor = Color.LimeGreen;
                btn_6_2.BackColor = Color.LimeGreen;
                btn_6_3.BackColor = Color.LimeGreen;
                btn_6_4.BackColor = Color.LimeGreen;
                btn_6_5.BackColor = Color.LimeGreen;
                btn_6_6.BackColor = Color.LimeGreen;
                btn_6_7.BackColor = Color.LimeGreen;
                btn_6_8.BackColor = Color.LimeGreen;
                btn_6_9.BackColor = Color.LimeGreen;
            }

            if (nextField == 7 || nextField == 10) {
                if (activeField != 10) { activeField = 7; }
                btn_7_1.BackColor = Color.LimeGreen;
                btn_7_2.BackColor = Color.LimeGreen;
                btn_7_3.BackColor = Color.LimeGreen;
                btn_7_4.BackColor = Color.LimeGreen;
                btn_7_5.BackColor = Color.LimeGreen;
                btn_7_6.BackColor = Color.LimeGreen;
                btn_7_7.BackColor = Color.LimeGreen;
                btn_7_8.BackColor = Color.LimeGreen;
                btn_7_9.BackColor = Color.LimeGreen;
            }

            if (nextField == 8 || nextField == 10) {
                if (activeField != 10) { activeField = 8; }
                btn_8_1.BackColor = Color.LimeGreen;
                btn_8_2.BackColor = Color.LimeGreen;
                btn_8_3.BackColor = Color.LimeGreen;
                btn_8_4.BackColor = Color.LimeGreen;
                btn_8_5.BackColor = Color.LimeGreen;
                btn_8_6.BackColor = Color.LimeGreen;
                btn_8_7.BackColor = Color.LimeGreen;
                btn_8_8.BackColor = Color.LimeGreen;
                btn_8_9.BackColor = Color.LimeGreen;
            }

            if (nextField == 9 || nextField == 10) {
                if (activeField != 10) { activeField = 9; }
                btn_9_1.BackColor = Color.LimeGreen;
                btn_9_2.BackColor = Color.LimeGreen;
                btn_9_3.BackColor = Color.LimeGreen;
                btn_9_4.BackColor = Color.LimeGreen;
                btn_9_5.BackColor = Color.LimeGreen;
                btn_9_6.BackColor = Color.LimeGreen;
                btn_9_7.BackColor = Color.LimeGreen;
                btn_9_8.BackColor = Color.LimeGreen;
                btn_9_9.BackColor = Color.LimeGreen;
            }

            activeField = Convert.ToInt16(nextField); // set the active field to next choice

            //sets the label to the current Player:
            if (playerX) { lbl_current_player.Text = "Current Player: X"; } else { lbl_current_player.Text = "Current Player: O"; }
        }

        private void check_for_win(int currentField)
        {
            if (currentField == 1) {
                if (btn_1_1.Text == btn_1_2.Text && btn_1_2.Text == btn_1_3.Text && (btn_1_1.Text == "X" || btn_1_1.Text == "O")) // Check for First row in First Field
                {
                    disable_or_activate_field(1, false);
                    btn_field1.Text = btn_1_1.Text; 
                    btn_field1.Visible = true;
                } 
                else if (btn_1_4.Text == btn_1_5.Text && btn_1_5.Text == btn_1_6.Text && (btn_1_4.Text == "X" || btn_1_4.Text == "O")) // Check for Second row in First Field
                {
                    disable_or_activate_field(1, false);
                    btn_field1.Text = btn_1_4.Text; 
                    btn_field1.Visible = true;
                }
                else if (btn_1_7.Text == btn_1_8.Text && btn_1_8.Text == btn_1_9.Text && (btn_1_7.Text == "X" || btn_1_7.Text == "O")) // Check for Third row in First Field
                {
                    disable_or_activate_field(1, false);
                    btn_field1.Text = btn_1_7.Text; 
                    btn_field1.Visible = true;
                }
                else if (btn_1_1.Text == btn_1_4.Text && btn_1_4.Text == btn_1_7.Text && (btn_1_1.Text == "X" || btn_1_1.Text == "O")) // Check for first column in First Field
                {
                    disable_or_activate_field(1, false);
                    btn_field1.Text = btn_1_1.Text; 
                    btn_field1.Visible = true;
                }
                else if (btn_1_2.Text == btn_1_5.Text && btn_1_5.Text == btn_1_8.Text && (btn_1_2.Text == "X" || btn_1_2.Text == "O")) // Check for second column in First Field
                {
                    disable_or_activate_field(1, false);
                    btn_field1.Text = btn_1_2.Text; 
                    btn_field1.Visible = true;
                }
                else if (btn_1_3.Text == btn_1_6.Text && btn_1_6.Text == btn_1_9.Text && (btn_1_3.Text == "X" || btn_1_3.Text == "O")) // Check for third column in First Field
                {
                    disable_or_activate_field(1, false);
                    btn_field1.Text = btn_1_3.Text; 
                    btn_field1.Visible = true;
                }
                else if (btn_1_1.Text == btn_1_5.Text && btn_1_5.Text == btn_1_9.Text && (btn_1_1.Text == "X" || btn_1_1.Text == "O")) // Check from left top to right bottom in first Field
                {
                    disable_or_activate_field(1, false);
                    btn_field1.Text = btn_1_1.Text; 
                    btn_field1.Visible = true;
                }
                else if (btn_1_3.Text == btn_1_5.Text && btn_1_5.Text == btn_1_7.Text && (btn_1_3.Text == "X" || btn_1_3.Text == "O")) // Check from left top to right bottom in first Field
                {
                    disable_or_activate_field(1, false);
                    btn_field1.Text = btn_1_3.Text; 
                    btn_field1.Visible = true;
                }
            }
            if (currentField == 2) {
                if (btn_2_1.Text == btn_2_2.Text && btn_2_2.Text == btn_2_3.Text && (btn_2_1.Text == "X" || btn_2_1.Text == "O")) // Check for First row in First Field
                {
                    disable_or_activate_field(2, false);
                    btn_field2.Text = btn_2_1.Text;
                    btn_field2.Visible = true;
                }
                else if (btn_2_4.Text == btn_2_5.Text && btn_2_5.Text == btn_2_6.Text && (btn_2_4.Text == "X" || btn_2_4.Text == "O")) // Check for Second row in First Field
                {
                    disable_or_activate_field(2, false);
                    btn_field2.Text = btn_2_4.Text;
                    btn_field2.Visible = true;
                }
                else if (btn_2_7.Text == btn_2_8.Text && btn_2_8.Text == btn_2_9.Text && (btn_2_7.Text == "X" || btn_2_7.Text == "O")) // Check for Third row in First Field
                {
                    disable_or_activate_field(2, false);
                    btn_field2.Text = btn_2_7.Text;
                    btn_field2.Visible = true;
                }
                else if (btn_2_1.Text == btn_2_4.Text && btn_2_4.Text == btn_2_7.Text && (btn_2_1.Text == "X" || btn_2_1.Text == "O")) // Check for first column in First Field
                {
                    disable_or_activate_field(2, false);
                    btn_field2.Text = btn_2_1.Text;
                    btn_field2.Visible = true;
                }
                else if (btn_2_2.Text == btn_2_5.Text && btn_2_5.Text == btn_2_8.Text && (btn_2_2.Text == "X" || btn_2_2.Text == "O")) // Check for second column in First Field
                {
                    disable_or_activate_field(2, false);
                    btn_field2.Text = btn_2_2.Text;
                    btn_field2.Visible = true;
                }
                else if (btn_2_3.Text == btn_2_6.Text && btn_2_6.Text == btn_2_9.Text && (btn_2_3.Text == "X" || btn_2_3.Text == "O")) // Check for third column in First Field
                {
                    disable_or_activate_field(2, false);
                    btn_field2.Text = btn_2_3.Text;
                    btn_field2.Visible = true;
                }
                else if (btn_2_1.Text == btn_2_5.Text && btn_2_5.Text == btn_2_9.Text && (btn_2_1.Text == "X" || btn_2_1.Text == "O")) // Check from left top to right bottom in first Field
                {
                    disable_or_activate_field(2, false);
                    btn_field2.Text = btn_2_1.Text;
                    btn_field2.Visible = true;
                }
                else if (btn_2_3.Text == btn_2_5.Text && btn_2_5.Text == btn_2_7.Text && (btn_2_3.Text == "X" || btn_2_3.Text == "O")) // Check from left top to right bottom in first Field
                {
                    disable_or_activate_field(2, false);
                    btn_field2.Text = btn_2_3.Text;
                    btn_field2.Visible = true;
                }
            }
            if (currentField == 3) {
                if (btn_3_1.Text == btn_3_2.Text && btn_3_2.Text == btn_3_3.Text && (btn_3_1.Text == "X" || btn_3_1.Text == "O"))
                {
                    disable_or_activate_field(3, false);
                    btn_field3.Text = btn_3_1.Text;
                    btn_field3.Visible = true;
                }
                else if (btn_3_4.Text == btn_3_5.Text && btn_3_5.Text == btn_3_6.Text && (btn_3_4.Text == "X" || btn_3_4.Text == "O"))
                {
                    disable_or_activate_field(3, false);
                    btn_field3.Text = btn_3_4.Text;
                    btn_field3.Visible = true;
                }
                else if (btn_3_7.Text == btn_3_8.Text && btn_3_8.Text == btn_3_9.Text && (btn_3_7.Text == "X" || btn_3_7.Text == "O"))
                {
                    disable_or_activate_field(3, false);
                    btn_field3.Text = btn_3_7.Text;
                    btn_field3.Visible = true;
                }
                else if (btn_3_1.Text == btn_3_4.Text && btn_3_4.Text == btn_3_7.Text && (btn_3_1.Text == "X" || btn_3_1.Text == "O"))
                {
                    disable_or_activate_field(3, false);
                    btn_field3.Text = btn_3_1.Text;
                    btn_field3.Visible = true;
                }
                else if (btn_3_2.Text == btn_3_5.Text && btn_3_5.Text == btn_3_8.Text && (btn_3_2.Text == "X" || btn_3_2.Text == "O"))
                {
                    disable_or_activate_field(3, false);
                    btn_field3.Text = btn_3_2.Text;
                    btn_field3.Visible = true;
                }
                else if (btn_3_3.Text == btn_3_6.Text && btn_3_6.Text == btn_3_9.Text && (btn_3_3.Text == "X" || btn_3_3.Text == "O"))
                {
                    disable_or_activate_field(3, false);
                    btn_field3.Text = btn_3_3.Text;
                    btn_field3.Visible = true;
                }
                else if (btn_3_1.Text == btn_3_5.Text && btn_3_5.Text == btn_3_9.Text && (btn_3_1.Text == "X" || btn_3_1.Text == "O"))
                {
                    disable_or_activate_field(3, false);
                    btn_field3.Text = btn_3_1.Text;
                    btn_field3.Visible = true;
                }
                else if (btn_3_3.Text == btn_3_5.Text && btn_3_5.Text == btn_3_7.Text && (btn_3_3.Text == "X" || btn_3_3.Text == "O"))
                {
                    disable_or_activate_field(3, false);
                    btn_field3.Text = btn_3_3.Text;
                    btn_field3.Visible = true;
                }
            }
            if (currentField == 4) {
                if (btn_4_1.Text == btn_4_2.Text && btn_4_2.Text == btn_4_3.Text && (btn_4_1.Text == "X" || btn_4_1.Text == "O"))
                {
                    disable_or_activate_field(4, false);
                    btn_field4.Text = btn_4_1.Text;
                    btn_field4.Visible = true;
                }
                else if (btn_4_4.Text == btn_4_5.Text && btn_4_5.Text == btn_4_6.Text && (btn_4_4.Text == "X" || btn_4_4.Text == "O"))
                {
                    disable_or_activate_field(4, false);
                    btn_field4.Text = btn_4_4.Text;
                    btn_field4.Visible = true;
                }
                else if (btn_4_7.Text == btn_4_8.Text && btn_4_8.Text == btn_4_9.Text && (btn_4_7.Text == "X" || btn_4_7.Text == "O"))
                {
                    disable_or_activate_field(4, false);
                    btn_field4.Text = btn_4_7.Text;
                    btn_field4.Visible = true;
                }
                else if (btn_4_1.Text == btn_4_4.Text && btn_4_4.Text == btn_4_7.Text && (btn_4_1.Text == "X" || btn_4_1.Text == "O"))
                {
                    disable_or_activate_field(4, false);
                    btn_field4.Text = btn_4_1.Text;
                    btn_field4.Visible = true;
                }
                else if (btn_4_2.Text == btn_4_5.Text && btn_4_5.Text == btn_4_8.Text && (btn_4_2.Text == "X" || btn_4_2.Text == "O"))
                {
                    disable_or_activate_field(4, false);
                    btn_field4.Text = btn_4_2.Text;
                    btn_field4.Visible = true;
                }
                else if (btn_4_3.Text == btn_4_6.Text && btn_4_6.Text == btn_4_9.Text && (btn_4_3.Text == "X" || btn_4_3.Text == "O"))
                {
                    disable_or_activate_field(4, false);
                    btn_field4.Text = btn_4_3.Text;
                    btn_field4.Visible = true;
                }
                else if (btn_4_1.Text == btn_4_5.Text && btn_4_5.Text == btn_4_9.Text && (btn_4_1.Text == "X" || btn_4_1.Text == "O"))
                {
                    disable_or_activate_field(4, false);
                    btn_field4.Text = btn_4_1.Text;
                    btn_field4.Visible = true;
                }
                else if (btn_4_3.Text == btn_4_5.Text && btn_4_5.Text == btn_4_7.Text && (btn_4_3.Text == "X" || btn_4_3.Text == "O"))
                {
                    disable_or_activate_field(4, false);
                    btn_field4.Text = btn_4_3.Text;
                    btn_field4.Visible = true;
                }
            }
            if (currentField == 5) {
                if (btn_5_1.Text == btn_5_2.Text && btn_5_2.Text == btn_5_3.Text && (btn_5_1.Text == "X" || btn_5_1.Text == "O"))
                {
                    disable_or_activate_field(5, false);
                    btn_field5.Text = btn_5_1.Text;
                    btn_field5.Visible = true;
                }
                else if (btn_5_4.Text == btn_5_5.Text && btn_5_5.Text == btn_5_6.Text && (btn_5_4.Text == "X" || btn_5_4.Text == "O"))
                {
                    disable_or_activate_field(5, false);
                    btn_field5.Text = btn_5_4.Text;
                    btn_field5.Visible = true;
                }
                else if (btn_5_7.Text == btn_5_8.Text && btn_5_8.Text == btn_5_9.Text && (btn_5_7.Text == "X" || btn_5_7.Text == "O"))
                {
                    disable_or_activate_field(5, false);
                    btn_field5.Text = btn_5_7.Text;
                    btn_field5.Visible = true;
                }
                else if (btn_5_1.Text == btn_5_4.Text && btn_5_4.Text == btn_5_7.Text && (btn_5_1.Text == "X" || btn_5_1.Text == "O"))
                {
                    disable_or_activate_field(5, false);
                    btn_field5.Text = btn_5_1.Text;
                    btn_field5.Visible = true;
                }
                else if (btn_5_2.Text == btn_5_5.Text && btn_5_5.Text == btn_5_8.Text && (btn_5_2.Text == "X" || btn_5_2.Text == "O"))
                {
                    disable_or_activate_field(5, false);
                    btn_field5.Text = btn_5_2.Text;
                    btn_field5.Visible = true;
                }
                else if (btn_5_3.Text == btn_5_6.Text && btn_5_6.Text == btn_5_9.Text && (btn_5_3.Text == "X" || btn_5_3.Text == "O"))
                {
                    disable_or_activate_field(5, false);
                    btn_field5.Text = btn_5_3.Text;
                    btn_field5.Visible = true;
                }
                else if (btn_5_1.Text == btn_5_5.Text && btn_5_5.Text == btn_5_9.Text && (btn_5_1.Text == "X" || btn_5_1.Text == "O"))
                {
                    disable_or_activate_field(5, false);
                    btn_field5.Text = btn_5_1.Text;
                    btn_field5.Visible = true;
                }
                else if (btn_5_3.Text == btn_5_5.Text && btn_5_5.Text == btn_5_7.Text && (btn_5_3.Text == "X" || btn_5_3.Text == "O"))
                {
                    disable_or_activate_field(5, false);
                    btn_field5.Text = btn_5_3.Text;
                    btn_field5.Visible = true;
                }
            }
            if (currentField == 6) {
                if (btn_6_1.Text == btn_6_2.Text && btn_6_2.Text == btn_6_3.Text && (btn_6_1.Text == "X" || btn_6_1.Text == "O"))
                {
                    disable_or_activate_field(6, false);
                    btn_field6.Text = btn_6_1.Text;
                    btn_field6.Visible = true;
                }
                else if (btn_6_4.Text == btn_6_5.Text && btn_6_5.Text == btn_6_6.Text && (btn_6_4.Text == "X" || btn_6_4.Text == "O"))
                {
                    disable_or_activate_field(6, false);
                    btn_field6.Text = btn_6_4.Text;
                    btn_field6.Visible = true;
                }
                else if (btn_6_7.Text == btn_6_8.Text && btn_6_8.Text == btn_6_7.Text && (btn_6_7.Text == "X" || btn_6_7.Text == "O"))
                {
                    disable_or_activate_field(6, false);
                    btn_field6.Text = btn_6_7.Text;
                    btn_field6.Visible = true;
                }
                else if (btn_6_1.Text == btn_6_4.Text && btn_6_4.Text == btn_6_7.Text && (btn_6_1.Text == "X" || btn_6_1.Text == "O"))
                {
                    disable_or_activate_field(6, false);
                    btn_field6.Text = btn_6_1.Text;
                    btn_field6.Visible = true;
                }
                else if (btn_6_2.Text == btn_6_5.Text && btn_6_5.Text == btn_6_9.Text && (btn_6_2.Text == "X" || btn_6_2.Text == "O"))
                {
                    disable_or_activate_field(6, false);
                    btn_field6.Text = btn_6_2.Text;
                    btn_field6.Visible = true;
                }
                else if (btn_6_3.Text == btn_6_6.Text && btn_6_6.Text == btn_6_9.Text && (btn_6_3.Text == "X" || btn_6_3.Text == "O"))
                {
                    disable_or_activate_field(6, false);
                    btn_field6.Text = btn_6_3.Text;
                    btn_field6.Visible = true;
                }
                else if (btn_6_1.Text == btn_6_5.Text && btn_6_5.Text == btn_6_9.Text && (btn_6_1.Text == "X" || btn_6_1.Text == "O"))
                {
                    disable_or_activate_field(6, false);
                    btn_field6.Text = btn_6_1.Text;
                    btn_field6.Visible = true;
                }
                else if (btn_6_3.Text == btn_6_5.Text && btn_6_5.Text == btn_6_7.Text && (btn_6_3.Text == "X" || btn_6_3.Text == "O"))
                {
                    disable_or_activate_field(6, false);
                    btn_field6.Text = btn_6_3.Text;
                    btn_field6.Visible = true;
                }
            }
            if (currentField == 7) {
                if (btn_7_1.Text == btn_7_2.Text && btn_7_2.Text == btn_7_3.Text && (btn_7_1.Text == "X" || btn_7_1.Text == "O"))
                {
                    disable_or_activate_field(7, false);
                    btn_field7.Text = btn_7_1.Text;
                    btn_field7.Visible = true;
                }
                else if (btn_7_4.Text == btn_7_5.Text && btn_7_5.Text == btn_7_6.Text && (btn_7_4.Text == "X" || btn_7_4.Text == "O"))
                {
                    disable_or_activate_field(7, false);
                    btn_field7.Text = btn_7_4.Text;
                    btn_field7.Visible = true;
                }
                else if (btn_7_7.Text == btn_7_8.Text && btn_7_8.Text == btn_7_9.Text && (btn_7_7.Text == "X" || btn_7_7.Text == "O"))
                {
                    disable_or_activate_field(7, false);
                    btn_field7.Text = btn_7_7.Text;
                    btn_field7.Visible = true;
                }
                else if (btn_7_1.Text == btn_7_4.Text && btn_7_4.Text == btn_7_7.Text && (btn_7_1.Text == "X" || btn_7_1.Text == "O"))
                {
                    disable_or_activate_field(7, false);
                    btn_field7.Text = btn_7_1.Text;
                    btn_field7.Visible = true;
                }
                else if (btn_7_2.Text == btn_7_5.Text && btn_7_5.Text == btn_7_8.Text && (btn_7_2.Text == "X" || btn_7_2.Text == "O"))
                {
                    disable_or_activate_field(7, false);
                    btn_field7.Text = btn_7_2.Text;
                    btn_field7.Visible = true;
                }
                else if (btn_7_3.Text == btn_7_6.Text && btn_7_6.Text == btn_7_9.Text && (btn_7_3.Text == "X" || btn_7_3.Text == "O"))
                {
                    disable_or_activate_field(7, false);
                    btn_field7.Text = btn_7_3.Text;
                    btn_field7.Visible = true;
                }
                else if (btn_7_1.Text == btn_7_5.Text && btn_7_5.Text == btn_7_9.Text && (btn_7_1.Text == "X" || btn_7_1.Text == "O"))
                {
                    disable_or_activate_field(7, false);
                    btn_field7.Text = btn_7_1.Text;
                    btn_field7.Visible = true;
                }
                else if (btn_7_3.Text == btn_7_5.Text && btn_7_5.Text == btn_7_7.Text && (btn_7_3.Text == "X" || btn_7_3.Text == "O"))
                {
                    disable_or_activate_field(7, false);
                    btn_field7.Text = btn_7_3.Text;
                    btn_field7.Visible = true;
                }
            }
            if (currentField == 8) {
                if (btn_8_1.Text == btn_8_2.Text && btn_8_2.Text == btn_8_3.Text && (btn_8_1.Text == "X" || btn_8_1.Text == "O"))
                {
                    disable_or_activate_field(8, false);
                    btn_field8.Text = btn_8_1.Text;
                    btn_field8.Visible = true;
                }
                else if (btn_8_4.Text == btn_8_5.Text && btn_8_5.Text == btn_8_6.Text && (btn_8_4.Text == "X" || btn_8_4.Text == "O"))
                {
                    disable_or_activate_field(8, false);
                    btn_field8.Text = btn_8_4.Text;
                    btn_field8.Visible = true;
                }
                else if (btn_8_7.Text == btn_8_8.Text && btn_8_8.Text == btn_8_9.Text && (btn_8_7.Text == "X" || btn_8_7.Text == "O"))
                {
                    disable_or_activate_field(8, false);
                    btn_field8.Text = btn_8_7.Text;
                    btn_field8.Visible = true;
                }
                else if (btn_8_1.Text == btn_8_4.Text && btn_8_4.Text == btn_8_7.Text && (btn_8_1.Text == "X" || btn_8_1.Text == "O"))
                {
                    disable_or_activate_field(8, false);
                    btn_field8.Text = btn_8_1.Text;
                    btn_field8.Visible = true;
                }
                else if (btn_8_2.Text == btn_8_5.Text && btn_8_5.Text == btn_8_8.Text && (btn_8_2.Text == "X" || btn_8_2.Text == "O"))
                {
                    disable_or_activate_field(8, false);
                    btn_field8.Text = btn_8_2.Text;
                    btn_field8.Visible = true;
                }
                else if (btn_8_3.Text == btn_8_6.Text && btn_8_6.Text == btn_8_9.Text && (btn_8_3.Text == "X" || btn_8_3.Text == "O"))
                {
                    disable_or_activate_field(8, false);
                    btn_field8.Text = btn_8_3.Text;
                    btn_field8.Visible = true;
                }
                else if (btn_8_1.Text == btn_8_5.Text && btn_8_5.Text == btn_8_9.Text && (btn_8_1.Text == "X" || btn_8_1.Text == "O"))
                {
                    disable_or_activate_field(8, false);
                    btn_field8.Text = btn_8_1.Text;
                    btn_field8.Visible = true;
                }
                else if (btn_8_3.Text == btn_8_5.Text && btn_8_5.Text == btn_8_7.Text && (btn_8_3.Text == "X" || btn_8_3.Text == "O"))
                {
                    disable_or_activate_field(8, false);
                    btn_field8.Text = btn_8_3.Text;
                    btn_field8.Visible = true;
                }
            }
            if (currentField == 9) {
                if (btn_9_1.Text == btn_9_2.Text && btn_9_2.Text == btn_9_3.Text && (btn_9_1.Text == "X" || btn_9_1.Text == "O")) // fisrt row
                {
                    disable_or_activate_field(9, false);
                    btn_field9.Text = btn_9_1.Text;
                    btn_field9.Visible = true;
                }
                else if (btn_9_4.Text == btn_9_5.Text && btn_9_5.Text == btn_9_6.Text && (btn_9_4.Text == "X" || btn_9_4.Text == "O")) // second row
                {
                    disable_or_activate_field(9, false);
                    btn_field9.Text = btn_9_4.Text;
                    btn_field9.Visible = true;
                }
                else if (btn_9_7.Text == btn_9_8.Text && btn_9_8.Text == btn_9_9.Text && (btn_9_7.Text == "X" || btn_9_7.Text == "O")) // thrird row
                {
                    disable_or_activate_field(9, false);
                    btn_field9.Text = btn_9_7.Text;
                    btn_field9.Visible = true;
                }
                else if (btn_9_1.Text == btn_9_4.Text && btn_9_4.Text == btn_9_7.Text && (btn_9_1.Text == "X" || btn_9_1.Text == "O"))
                {
                    disable_or_activate_field(9, false);
                    btn_field9.Text = btn_9_1.Text;
                    btn_field9.Visible = true;
                }
                else if (btn_9_2.Text == btn_9_5.Text && btn_9_5.Text == btn_9_8.Text && (btn_9_2.Text == "X" || btn_9_2.Text == "O"))
                {
                    disable_or_activate_field(9, false);
                    btn_field9.Text = btn_9_2.Text;
                    btn_field9.Visible = true;
                }
                else if (btn_9_3.Text == btn_9_6.Text && btn_9_6.Text == btn_9_9.Text && (btn_9_3.Text == "X" || btn_9_3.Text == "O"))
                {
                    disable_or_activate_field(9, false);
                    btn_field9.Text = btn_9_3.Text;
                    btn_field9.Visible = true;
                }
                else if (btn_9_1.Text == btn_9_5.Text && btn_9_5.Text == btn_9_9.Text && (btn_9_1.Text == "X" || btn_9_1.Text == "O"))
                {
                    disable_or_activate_field(9, false);
                    btn_field9.Text = btn_9_1.Text;
                    btn_field9.Visible = true;
                }
                else if (btn_9_3.Text == btn_9_5.Text && btn_9_5.Text == btn_9_7.Text && (btn_9_3.Text == "X" || btn_9_3.Text == "O"))
                {
                    disable_or_activate_field(9, false);
                    btn_field9.Text = btn_9_3.Text;
                    btn_field9.Visible = true;
                }
            }

            check_for_global_win();
        }

        private void check_for_global_win() // checks if the whole tictactoe got solved
        {
            if (btn_field1.Text == btn_field2.Text && btn_field2.Text == btn_field3.Text && (btn_field1.Text == "X" || btn_field1.Text == "O")) // Check for First row
            {
                activeField = 0;
                reset_colors();
                lbl_winner.Text = "Winner: Player " + btn_field1.Text;

            }
            else if (btn_field4.Text == btn_field5.Text && btn_field5.Text == btn_field6.Text && (btn_field4.Text == "X" || btn_field4.Text == "O")) // Check for Second row
            {
                activeField = 0;
                reset_colors();
                lbl_winner.Text = "Winner: Player " + btn_field4.Text;
            }
            else if (btn_field7.Text == btn_field8.Text && btn_field8.Text == btn_field7.Text && (btn_field7.Text == "X" || btn_field7.Text == "O")) // Check for Third row
            {
                activeField = 0;
                reset_colors();
                lbl_winner.Text = "Winner: Player " + btn_field7.Text;
            }
            else if (btn_field1.Text == btn_field4.Text && btn_field4.Text == btn_field7.Text && (btn_field1.Text == "X" || btn_field1.Text == "O")) // Check for first column
            {
                activeField = 0;
                reset_colors();
                lbl_winner.Text = "Winner: Player " + btn_field1.Text;
            }
            else if (btn_field2.Text == btn_field5.Text && btn_field5.Text == btn_field8.Text && (btn_field2.Text == "X" || btn_field2.Text == "O")) // Check for second column
            {
                activeField = 0;
                reset_colors();
                lbl_winner.Text = "Winner: Player " + btn_field2.Text;
            }
            else if (btn_field3.Text == btn_field6.Text && btn_field6.Text == btn_field9.Text && (btn_field3.Text == "X" || btn_field3.Text == "O")) // Check for third column
            {
                activeField = 0;
                reset_colors();
                lbl_winner.Text = "Winner: Player " + btn_field3.Text;
            }
            else if (btn_field1.Text == btn_field5.Text && btn_field5.Text == btn_field9.Text && (btn_field1.Text == "X" || btn_field1.Text == "O")) // Check from left top to right bottom
            {
                activeField = 0;
                reset_colors();
                lbl_winner.Text = "Winner: Player " + btn_field1.Text;
            }
            else if (btn_field3.Text == btn_field5.Text && btn_field5.Text == btn_field7.Text && (btn_field3.Text == "X" || btn_field3.Text == "O")) // Check from left top to right bottom
            {
                activeField = 0;
                reset_colors();
                lbl_winner.Text = "Winner: Player " + btn_field3.Text;
            }
            //check for draw
            else if (btn_field1.Text != "" && btn_field2.Text != "" && btn_field3.Text != "" && btn_field4.Text != "" && btn_field5.Text != "" && btn_field6.Text != "" && btn_field7.Text != "" && btn_field8.Text != "" && btn_field9.Text != "")
            {
                activeField = 0; // just in case ;)
                reset_colors();
                lbl_winner.ForeColor = Color.Red;
                lbl_winner.Text = "Draw!";
            }
        }

        private void disable_or_activate_field(int fieldToDisable, bool btn_visability)
        {
            if (fieldToDisable == 1 || fieldToDisable == 10)
            {
                btn_1_1.Visible = btn_visability;
                btn_1_2.Visible = btn_visability;
                btn_1_3.Visible = btn_visability;
                btn_1_4.Visible = btn_visability;
                btn_1_5.Visible = btn_visability;
                btn_1_6.Visible = btn_visability;
                btn_1_7.Visible = btn_visability;
                btn_1_8.Visible = btn_visability;
                btn_1_9.Visible = btn_visability;
            }
            if (fieldToDisable == 2 || fieldToDisable == 10)
            {
                btn_2_1.Visible = btn_visability;
                btn_2_2.Visible = btn_visability;
                btn_2_3.Visible = btn_visability;
                btn_2_4.Visible = btn_visability;
                btn_2_5.Visible = btn_visability;
                btn_2_6.Visible = btn_visability;
                btn_2_7.Visible = btn_visability;
                btn_2_8.Visible = btn_visability;
                btn_2_9.Visible = btn_visability;
            }
            if (fieldToDisable == 3 || fieldToDisable == 10)
            {
                btn_3_1.Visible = btn_visability;
                btn_3_2.Visible = btn_visability;
                btn_3_3.Visible = btn_visability;
                btn_3_4.Visible = btn_visability;
                btn_3_5.Visible = btn_visability;
                btn_3_6.Visible = btn_visability;
                btn_3_7.Visible = btn_visability;
                btn_3_8.Visible = btn_visability;
                btn_3_9.Visible = btn_visability;
            }
            if (fieldToDisable == 4 || fieldToDisable == 10)
            {
                btn_4_1.Visible = btn_visability;
                btn_4_2.Visible = btn_visability;
                btn_4_3.Visible = btn_visability;
                btn_4_4.Visible = btn_visability;
                btn_4_5.Visible = btn_visability;
                btn_4_6.Visible = btn_visability;
                btn_4_7.Visible = btn_visability;
                btn_4_8.Visible = btn_visability;
                btn_4_9.Visible = btn_visability;
            }
            if (fieldToDisable == 5 || fieldToDisable == 10)
            {
                btn_5_1.Visible = btn_visability;
                btn_5_2.Visible = btn_visability;
                btn_5_3.Visible = btn_visability;
                btn_5_4.Visible = btn_visability;
                btn_5_5.Visible = btn_visability;
                btn_5_6.Visible = btn_visability;
                btn_5_7.Visible = btn_visability;
                btn_5_8.Visible = btn_visability;
                btn_5_9.Visible = btn_visability;
            }
            if (fieldToDisable == 6 || fieldToDisable == 10)
            {
                btn_6_1.Visible = btn_visability;
                btn_6_2.Visible = btn_visability;
                btn_6_3.Visible = btn_visability;
                btn_6_4.Visible = btn_visability;
                btn_6_5.Visible = btn_visability;
                btn_6_6.Visible = btn_visability;
                btn_6_7.Visible = btn_visability;
                btn_6_8.Visible = btn_visability;
                btn_6_9.Visible = btn_visability;

            }
            if (fieldToDisable == 7 || fieldToDisable == 10)
            {
                btn_7_1.Visible = btn_visability;
                btn_7_2.Visible = btn_visability;
                btn_7_3.Visible = btn_visability;
                btn_7_4.Visible = btn_visability;
                btn_7_5.Visible = btn_visability;
                btn_7_6.Visible = btn_visability;
                btn_7_7.Visible = btn_visability;
                btn_7_8.Visible = btn_visability;
                btn_7_9.Visible = btn_visability;
            }
            if (fieldToDisable == 8 || fieldToDisable == 10)
            {
                btn_8_1.Visible = btn_visability;
                btn_8_2.Visible = btn_visability;
                btn_8_3.Visible = btn_visability;
                btn_8_4.Visible = btn_visability;
                btn_8_5.Visible = btn_visability;
                btn_8_6.Visible = btn_visability;
                btn_8_7.Visible = btn_visability;
                btn_8_8.Visible = btn_visability;
                btn_8_9.Visible = btn_visability;
            }
            if (fieldToDisable > 8)
            {
                btn_9_1.Visible = btn_visability;
                btn_9_2.Visible = btn_visability;
                btn_9_3.Visible = btn_visability;
                btn_9_4.Visible = btn_visability;
                btn_9_5.Visible = btn_visability;
                btn_9_6.Visible = btn_visability;
                btn_9_7.Visible = btn_visability;
                btn_9_8.Visible = btn_visability;
                btn_9_9.Visible = btn_visability;
            }
        }

        private void btn_1_1_Click(object sender, EventArgs e)
        {
            if (btn_1_1.Text == "" && (activeField == 1 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                {btn_1_1.Text = "X";} else {btn_1_1.Text = "O";}
                check_for_win(1);
                next_turn(nextField: 1);
            }
        }

        private void btn_1_2_Click(object sender, EventArgs e)
        {
            if (btn_1_2.Text == "" && (activeField == 1 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_1_2.Text = "X"; }
                else { btn_1_2.Text = "O"; }
                check_for_win(1);
                next_turn(nextField: 2);
            }
        }

        private void btn_1_3_Click(object sender, EventArgs e)
        {
            if (btn_1_3.Text == "" && (activeField == 1 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_1_3.Text = "X"; }
                else { btn_1_3.Text = "O"; }
                check_for_win(1);
                next_turn(nextField: 3);
            }
        }

        private void btn_1_4_Click(object sender, EventArgs e)
        {
            if (btn_1_4.Text == "" && (activeField == 1 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_1_4.Text = "X"; }
                else { btn_1_4.Text = "O"; }
                check_for_win(1);
                next_turn(nextField: 4);
            }
        }

        private void btn_1_5_Click(object sender, EventArgs e)
        {
            if (btn_1_5.Text == "" && (activeField == 1 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_1_5.Text = "X"; }
                else { btn_1_5.Text = "O"; }
                check_for_win(1);
                next_turn(nextField: 5);
            }
        }

        private void btn_1_6_Click(object sender, EventArgs e)
        {
            if (btn_1_6.Text == "" && (activeField == 1 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_1_6.Text = "X"; }
                else { btn_1_6.Text = "O"; }
                check_for_win(1);
                next_turn(nextField: 6);
            }
        }

        private void btn_1_7_Click(object sender, EventArgs e)
        {
            if (btn_1_7.Text == "" && (activeField == 1 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_1_7.Text = "X"; }
                else { btn_1_7.Text = "O"; }
                check_for_win(1);
                next_turn(nextField: 7);
            }
        }

        private void btn_1_8_Click(object sender, EventArgs e)
        {
            if (btn_1_8.Text == "" && (activeField == 1 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_1_8.Text = "X"; }
                else { btn_1_8.Text = "O"; }
                check_for_win(1);
                next_turn(nextField: 8);
            }
        }

        private void btn_1_9_Click(object sender, EventArgs e)
        {
            if (btn_1_9.Text == "" && (activeField == 1 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_1_9.Text = "X"; }
                else { btn_1_9.Text = "O"; }
                check_for_win(1);
                next_turn(nextField: 9);
            }
        }

        private void btn_2_1_Click(object sender, EventArgs e)
        {
            if (btn_2_1.Text == "" && (activeField == 2 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_2_1.Text = "X"; }
                else { btn_2_1.Text = "O"; }
                check_for_win(2);
                next_turn(nextField: 1);
            }
        }

        private void btn_2_2_Click(object sender, EventArgs e)
        {
            if (btn_2_2.Text == "" && (activeField == 2 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_2_2.Text = "X"; }
                else { btn_2_2.Text = "O"; }
                check_for_win(2);
                next_turn(nextField: 2);
            }
        }

        private void btn_2_3_Click(object sender, EventArgs e)
        {
            if (btn_2_3.Text == "" && (activeField == 2 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_2_3.Text = "X"; }
                else { btn_2_3.Text = "O"; }
                check_for_win(2);
                next_turn(nextField: 3);
            }
        }

        private void btn_2_4_Click(object sender, EventArgs e)
        {
            if (btn_2_4.Text == "" && (activeField == 2 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_2_4.Text = "X"; }
                else { btn_2_4.Text = "O"; }
                check_for_win(2);
                next_turn(nextField: 4);
            }
        }

        private void btn_2_5_Click(object sender, EventArgs e)
        {
            if (btn_2_5.Text == "" && (activeField == 2 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_2_5.Text = "X"; }
                else { btn_2_5.Text = "O"; }
                check_for_win(2);
                next_turn(nextField: 5);
            }
        }

        private void btn_2_6_Click(object sender, EventArgs e)
        {
            if (btn_2_6.Text == "" && (activeField == 2 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_2_6.Text = "X"; }
                else { btn_2_6.Text = "O"; }
                check_for_win(2);
                next_turn(nextField: 6);
            }
        }

        private void btn_2_7_Click(object sender, EventArgs e)
        {
            if (btn_2_7.Text == "" && (activeField == 2 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_2_7.Text = "X"; }
                else { btn_2_7.Text = "O"; }
                check_for_win(2);
                next_turn(nextField: 7);
            }
        }

        private void btn_2_8_Click(object sender, EventArgs e)
        {
            if (btn_2_8.Text == "" && (activeField == 2 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_2_8.Text = "X"; }
                else { btn_2_8.Text = "O"; }
                check_for_win(2);
                next_turn(nextField: 8);
            }
        }

        private void btn_2_9_Click(object sender, EventArgs e)
        {
            if (btn_2_9.Text == "" && (activeField == 2 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_2_9.Text = "X"; }
                else { btn_2_9.Text = "O"; }
                check_for_win(2);
                next_turn(nextField: 9);
            }
        }

        private void btn_3_1_Click(object sender, EventArgs e)
        {
            if (btn_3_1.Text == "" && (activeField == 3 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_3_1.Text = "X"; }
                else { btn_3_1.Text = "O"; }
                check_for_win(3);
                next_turn(nextField: 1);
            }
        }

        private void btn_3_2_Click(object sender, EventArgs e)
        {
            if (btn_3_2.Text == "" && (activeField == 3 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_3_2.Text = "X"; }
                else { btn_3_2.Text = "O"; }
                check_for_win(3);
                next_turn(nextField: 2);
            }
        }

        private void btn_3_3_Click(object sender, EventArgs e)
        {
            if (btn_3_3.Text == "" && (activeField == 3 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_3_3.Text = "X"; }
                else { btn_3_3.Text = "O"; }
                check_for_win(3);
                next_turn(nextField: 3);
            }
        }

        private void btn_3_4_Click(object sender, EventArgs e)
        {
            if (btn_3_4.Text == "" && (activeField == 3 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_3_4.Text = "X"; }
                else { btn_3_4.Text = "O"; }
                check_for_win(3);
                next_turn(nextField: 4);
            }
        }

        private void btn_3_5_Click(object sender, EventArgs e)
        {
            if (btn_3_5.Text == "" && (activeField == 3 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_3_5.Text = "X"; }
                else { btn_3_5.Text = "O"; }
                check_for_win(3);
                next_turn(nextField: 5);
            }
        }

        private void btn_3_6_Click(object sender, EventArgs e)
        {
            if (btn_3_6.Text == "" && (activeField == 3 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_3_6.Text = "X"; }
                else { btn_3_6.Text = "O"; }
                check_for_win(3);
                next_turn(nextField: 6);
            }
        }

        private void btn_3_7_Click(object sender, EventArgs e)
        {
            if (btn_3_7.Text == "" && (activeField == 3 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_3_7.Text = "X"; }
                else { btn_3_7.Text = "O"; }
                check_for_win(3);
                next_turn(nextField: 7);
            }
        }

        private void btn_3_8_Click(object sender, EventArgs e)
        {
            if (btn_3_8.Text == "" && (activeField == 3 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_3_8.Text = "X"; }
                else { btn_3_8.Text = "O"; }
                check_for_win(3);
                next_turn(nextField: 8);
            }
        }

        private void btn_3_9_Click(object sender, EventArgs e)
        {
            if (btn_3_9.Text == "" && (activeField == 3 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_3_9.Text = "X"; }
                else { btn_3_9.Text = "O"; }
                check_for_win(3);
                next_turn(nextField: 9);
            }
        }

        private void btn_4_1_Click(object sender, EventArgs e)
        {
            if (btn_4_1.Text == "" && (activeField == 4 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_4_1.Text = "X"; }
                else { btn_4_1.Text = "O"; }
                check_for_win(4);
                next_turn(nextField: 1);
            }
        }

        private void btn_4_2_Click(object sender, EventArgs e)
        {
            if (btn_4_2.Text == "" && (activeField == 4 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_4_2.Text = "X"; }
                else { btn_4_2.Text = "O"; }
                check_for_win(4);
                next_turn(nextField: 2);
            }
        }

        private void btn_4_3_Click(object sender, EventArgs e)
        {
            if (btn_4_3.Text == "" && (activeField == 4 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_4_3.Text = "X"; }
                else { btn_4_3.Text = "O"; }
                check_for_win(4);
                next_turn(nextField: 3);
            }
        }

        private void btn_4_4_Click(object sender, EventArgs e)
        {
            if (btn_4_4.Text == "" && (activeField == 4 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_4_4.Text = "X"; }
                else { btn_4_4.Text = "O"; }
                check_for_win(4);
                next_turn(nextField: 4);
            }
        }

        private void btn_4_5_Click(object sender, EventArgs e)
        {
            if (btn_4_5.Text == "" && (activeField == 4 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_4_5.Text = "X"; }
                else { btn_4_5.Text = "O"; }
                check_for_win(4);
                next_turn(nextField: 5);
            }
        }

        private void btn_4_6_Click(object sender, EventArgs e)
        {
            if (btn_4_6.Text == "" && (activeField == 4 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_4_6.Text = "X"; }
                else { btn_4_6.Text = "O"; }
                check_for_win(4);
                next_turn(nextField: 6);
            }
        }

        private void btn_4_7_Click(object sender, EventArgs e)
        {
            if (btn_4_7.Text == "" && (activeField == 4 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_4_7.Text = "X"; }
                else { btn_4_7.Text = "O"; }
                check_for_win(4);
                next_turn(nextField: 7);
            }
        }

        private void btn_4_8_Click(object sender, EventArgs e)
        {
            if (btn_4_8.Text == "" && (activeField == 4 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_4_8.Text = "X"; }
                else { btn_4_8.Text = "O"; }
                check_for_win(4);
                next_turn(nextField: 8);
            }
        }

        private void btn_4_9_Click(object sender, EventArgs e)
        {
            if (btn_4_9.Text == "" && (activeField == 4 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_4_9.Text = "X"; }
                else { btn_4_9.Text = "O"; }
                check_for_win(4);
                next_turn(nextField: 9);
            }
        }

        private void btn_5_1_Click(object sender, EventArgs e)
        {
            if (btn_5_1.Text == "" && (activeField == 5 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_5_1.Text = "X"; }
                else { btn_5_1.Text = "O"; }
                check_for_win(5);
                next_turn(nextField: 1);
            }
        }

        private void btn_5_2_Click(object sender, EventArgs e)
        {
            if (btn_5_2.Text == "" && (activeField == 5 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_5_2.Text = "X"; }
                else { btn_5_2.Text = "O"; }
                check_for_win(5);
                next_turn(nextField: 2);
            }
        }

        private void btn_5_3_Click(object sender, EventArgs e)
        {
            if (btn_5_3.Text == "" && (activeField == 5 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_5_3.Text = "X"; }
                else { btn_5_3.Text = "O"; }
                check_for_win(5);
                next_turn(nextField: 3);
            }
        }

        private void btn_5_4_Click(object sender, EventArgs e)
        {
            if (btn_5_4.Text == "" && (activeField == 5 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_5_4.Text = "X"; }
                else { btn_5_4.Text = "O"; }
                check_for_win(5);
                next_turn(nextField: 4);
            }
        }

        private void btn_5_5_Click(object sender, EventArgs e)
        {
            if (btn_5_5.Text == "" && (activeField == 5 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_5_5.Text = "X"; }
                else { btn_5_5.Text = "O"; }
                check_for_win(5);
                next_turn(nextField: 5);
            }
        }

        private void btn_5_6_Click(object sender, EventArgs e)
        {
            if (btn_5_6.Text == "" && (activeField == 5 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_5_6.Text = "X"; }
                else { btn_5_6.Text = "O"; }
                check_for_win(5);
                next_turn(nextField: 6);
            }
        }

        private void btn_5_7_Click(object sender, EventArgs e)
        {
            if (btn_5_7.Text == "" && (activeField == 5 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_5_7.Text = "X"; }
                else { btn_5_7.Text = "O"; }
                check_for_win(5);
                next_turn(nextField: 7);
            }
        }

        private void btn_5_8_Click(object sender, EventArgs e)
        {
            if (btn_5_8.Text == "" && (activeField == 5 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_5_8.Text = "X"; }
                else { btn_5_8.Text = "O"; }
                check_for_win(5);
                next_turn(nextField: 8);
            }
        }

        private void btn_5_9_Click(object sender, EventArgs e)
        {
            if (btn_5_9.Text == "" && (activeField == 5 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_5_9.Text = "X"; }
                else { btn_5_9.Text = "O"; }
                check_for_win(5);
                next_turn(nextField: 9);
            }
        }

        private void btn_6_1_Click(object sender, EventArgs e)
        {
            if (btn_6_1.Text == "" && (activeField == 6 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_6_1.Text = "X"; }
                else { btn_6_1.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 1);
            }
        }

        private void btn_6_2_Click(object sender, EventArgs e)
        {
            if (btn_6_2.Text == "" && (activeField == 6 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_6_2.Text = "X"; }
                else { btn_6_2.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 2);
            }
        }

        private void btn_6_3_Click(object sender, EventArgs e)
        {
            if (btn_6_3.Text == "" && (activeField == 6 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_6_3.Text = "X"; }
                else { btn_6_3.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 3);
            }
        }

        private void btn_6_4_Click(object sender, EventArgs e)
        {
            if (btn_6_4.Text == "" && (activeField == 6 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_6_4.Text = "X"; }
                else { btn_6_4.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 4);
            }
        }

        private void btn_6_5_Click(object sender, EventArgs e)
        {
            if (btn_6_5.Text == "" && (activeField == 6 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_6_5.Text = "X"; }
                else { btn_6_5.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 5);
            }
        }

        private void btn_6_6_Click(object sender, EventArgs e)
        {
            if (btn_6_6.Text == "" && (activeField == 6 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_6_6.Text = "X"; }
                else { btn_6_6.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 6);
            }
        }

        private void btn_6_7_Click(object sender, EventArgs e)
        {
            if (btn_6_7.Text == "" && (activeField == 6 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_6_7.Text = "X"; }
                else { btn_6_7.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 7);
            }
        }

        private void btn_6_8_Click(object sender, EventArgs e)
        {
            if (btn_6_8.Text == "" && (activeField == 6 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_6_8.Text = "X"; }
                else { btn_6_8.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 8);
            }
        }

        private void btn_6_9_Click(object sender, EventArgs e)
        {
            if (btn_6_9.Text == "" && (activeField == 6 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_6_9.Text = "X"; }
                else { btn_6_9.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 9);
            }
        }

        private void btn_7_1_Click(object sender, EventArgs e)
        {
            if (btn_7_1.Text == "" && (activeField == 7 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_7_1.Text = "X"; }
                else { btn_7_1.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 1);
            }
        }

        private void btn_7_2_Click(object sender, EventArgs e)
        {
            if (btn_7_2.Text == "" && (activeField == 7 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_7_2.Text = "X"; }
                else { btn_7_2.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 2);
            }
        }

        private void btn_7_3_Click(object sender, EventArgs e)
        {
            if (btn_7_3.Text == "" && (activeField == 7 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_7_3.Text = "X"; }
                else { btn_7_3.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 3);
            }
        }

        private void btn_7_4_Click(object sender, EventArgs e)
        {
            if (btn_7_4.Text == "" && (activeField == 7 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_7_4.Text = "X"; }
                else { btn_7_4.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 4);
            }
        }

        private void btn_7_5_Click(object sender, EventArgs e)
        {
            if (btn_7_5.Text == "" && (activeField == 7 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_7_5.Text = "X"; }
                else { btn_7_5.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 5);
            }
        }

        private void btn_7_6_Click(object sender, EventArgs e)
        {
            if (btn_7_6.Text == "" && (activeField == 7 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_7_6.Text = "X"; }
                else { btn_7_6.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 6);
            }
        }

        private void btn_7_7_Click(object sender, EventArgs e)
        {
            if (btn_7_7.Text == "" && (activeField == 7 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_7_7.Text = "X"; }
                else { btn_7_7.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 7);
            }
        }

        private void btn_7_8_Click(object sender, EventArgs e)
        {
            if (btn_7_8.Text == "" && (activeField == 7 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_7_8.Text = "X"; }
                else { btn_7_8.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 8);
            }
        }

        private void btn_7_9_Click(object sender, EventArgs e)
        {
            if (btn_7_9.Text == "" && (activeField == 7 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_7_9.Text = "X"; }
                else { btn_7_9.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 9);
            }
        }

        private void btn_8_1_Click(object sender, EventArgs e)
        {
            if (btn_8_1.Text == "" && (activeField == 8 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_8_1.Text = "X"; }
                else { btn_8_1.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 1);
            }
        }

        private void btn_8_2_Click(object sender, EventArgs e)
        {
            if (btn_8_2.Text == "" && (activeField == 8 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_8_2.Text = "X"; }
                else { btn_8_2.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 2);
            }
        }

        private void btn_8_3_Click(object sender, EventArgs e)
        {
            if (btn_8_3.Text == "" && (activeField == 8 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_8_3.Text = "X"; }
                else { btn_8_3.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 3);
            }
        }

        private void btn_8_4_Click(object sender, EventArgs e)
        {
            if (btn_8_4.Text == "" && (activeField == 8 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_8_4.Text = "X"; }
                else { btn_8_4.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 4);
            }
        }

        private void btn_8_5_Click(object sender, EventArgs e)
        {
            if (btn_8_5.Text == "" && (activeField == 8 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_8_5.Text = "X"; }
                else { btn_8_5.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 5);
            }
        }

        private void btn_8_6_Click(object sender, EventArgs e)
        {
            if (btn_8_6.Text == "" && (activeField == 8 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_8_6.Text = "X"; }
                else { btn_8_6.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 6);
            }
        }

        private void btn_8_7_Click(object sender, EventArgs e)
        {
            if (btn_8_7.Text == "" && (activeField == 8 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_8_7.Text = "X"; }
                else { btn_8_7.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 7);
            }
        }

        private void btn_8_8_Click(object sender, EventArgs e)
        {
            if (btn_8_8.Text == "" && (activeField == 8 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_8_8.Text = "X"; }
                else { btn_8_8.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 8);
            }
        }

        private void btn_8_9_Click(object sender, EventArgs e)
        {
            if (btn_8_9.Text == "" && (activeField == 8 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_8_9.Text = "X"; }
                else { btn_8_9.Text = "O"; }
                check_for_win(6);
                next_turn(nextField: 9);
            }
        }

        private void btn_9_1_Click(object sender, EventArgs e)
        {
            if (btn_9_1.Text == "" && (activeField == 9 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_9_1.Text = "X"; }
                else { btn_9_1.Text = "O"; }
                check_for_win(9);
                next_turn(nextField: 1);
            }
        }

        private void btn_9_2_Click(object sender, EventArgs e)
        {
            if (btn_9_2.Text == "" && (activeField == 9 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_9_2.Text = "X"; }
                else { btn_9_2.Text = "O"; }
                check_for_win(9);
                next_turn(nextField: 2);
            }
        }

        private void btn_9_3_Click(object sender, EventArgs e)
        {
            if (btn_9_3.Text == "" && (activeField == 9 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_9_3.Text = "X"; }
                else { btn_9_3.Text = "O"; }
                check_for_win(9);
                next_turn(nextField: 3);
            }
        }

        private void btn_9_4_Click(object sender, EventArgs e)
        {
            if (btn_9_4.Text == "" && (activeField == 9 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_9_4.Text = "X"; }
                else { btn_9_4.Text = "O"; }
                check_for_win(9);
                next_turn(nextField: 4);
            }
        }

        private void btn_9_5_Click(object sender, EventArgs e)
        {
            if (btn_9_5.Text == "" && (activeField == 9 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_9_5.Text = "X"; }
                else { btn_9_5.Text = "O"; }
                check_for_win(9);
                next_turn(nextField: 5);
            }
        }

        private void btn_9_6_Click(object sender, EventArgs e)
        {
            if (btn_9_6.Text == "" && (activeField == 9 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_9_6.Text = "X"; }
                else { btn_9_6.Text = "O"; }
                check_for_win(9);
                next_turn(nextField: 6);
            }
        }

        private void btn_9_7_Click(object sender, EventArgs e)
        {
            if (btn_9_7.Text == "" && (activeField == 9 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_9_7.Text = "X"; }
                else { btn_9_7.Text = "O"; }
                check_for_win(9);
                next_turn(nextField: 7);
            }
        }

        private void btn_9_8_Click(object sender, EventArgs e)
        {
            if (btn_9_8.Text == "" && (activeField == 9 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_9_8.Text = "X"; }
                else { btn_9_8.Text = "O"; }
                check_for_win(9);
                next_turn(nextField: 8);
            }
        }

        private void btn_9_9_Click(object sender, EventArgs e)
        {
            if (btn_9_9.Text == "" && (activeField == 9 || activeField == 10)) // checks if box clear and the Field aktive
            {
                if (playerX)
                { btn_9_9.Text = "X"; }
                else { btn_9_9.Text = "O"; }
                check_for_win(9);
                next_turn(nextField: 9);
            }
        }
    }
}
