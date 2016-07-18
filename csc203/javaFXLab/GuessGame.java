
/*******************************************************************************
* Conrad Horton
* CISC203 June 2016
* JavaFX Lab Part3 Guess Game
* 20170717
*******************************************************************************/

package rad;

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Graphics;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
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

  /*****************************************************************************
  * CTOR */
  /**
  *****************************************************************************/
  public GuessGame()
    {
    mGuessCount = 0;
    mBackGround = Color.LIGHT_GRAY;
    
    /** Make labels. **/
    mPrompt1Label = new JLabel("Guess a number from 1-1000.");
    mPrompt2Label = new JLabel("Enter your guess: ");
    mMessageLabel = new JLabel("Guess result appears here.");
    
    /** Make text field. **/
    mGuessInputTextField = new JTextField(5);
    
    /** Add action listeners. **/
    /** Add text listener. **/
    mGuessInputTextField.addActionListener(new ActionListener()
      {
      public void actionPerformed(ActionEvent e)
        {
        react(Integer.getInteger((mGuessInputTextField.getText())));
        }
      });
    
    /** Add new button listener. **/
    mNewGameButton.addActionListener(new ActionListener()
      {
      public void actionPerformed(ActionEvent e)
        {
        /** Reset the text, color, and fields. **/
        mBackGround = Color.LIGHT_GRAY;
        mNumber     = mGuessCount = mLastDistance = 0;
        mGuessInputTextField.setText("");
        paint(getGraphics());
        }
      });
    
    theGame();
    }

  /*****************************************************************************
  * paint */
  /**
  * Change background color.
  *****************************************************************************/
  public void paint(Graphics g)
    {
    super.paint(g);
    getContentPane().setBackground(mBackGround);
    }

  /*****************************************************************************
  * react */
  /**
  * React to the new guess.
  * @param  guess  User's guess.
  *****************************************************************************/
  public void react(int guess)
    {
    
    }
  
  /*****************************************************************************
  * theGame */
  /**
  * Run the game. 
  *****************************************************************************/
  public void theGame()
    {
    
    }
  
  public static void main(String args[])
    {
    
    }
  }