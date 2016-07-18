
/*******************************************************************************
* Conrad Horton
* CISC203 June 2016
* JavaFX Lab Part3 Guess Game
* 20170717
*******************************************************************************/

package rad;

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.util.Random;
import javax.swing.JButton;
import javax.swing.JCheckBox;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

/*******************************************************************************
* Class FXOne */
/**
*******************************************************************************/
class GuessGame extends JFrame
  {
  private static Random mRand = new Random();
  private int           mNumber;
  private int           mGuessCount;
  private int           mLastDistance;
  private JTextField    mGuessInputTextField;
  private JLabel        mPrompt1Label;
  private JLabel        mPrompt2Label;
  private JLabel        mMessageLabel;
  private JButton       mNewGameButton;
  private Color         mBackGround;
  
  public GuessGame()
    {
    
    }
  
  
  public static void main(String args[])
    {
    
    }
  }