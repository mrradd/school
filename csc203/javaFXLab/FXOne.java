
/*******************************************************************************
* Conrad Horton
* CISC203 June 2016
* JavaFX Lab Part2
* 20170717
*******************************************************************************/

package rad;

import java.awt.FlowLayout;
import java.awt.GridLayout;
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
class FXOne extends JFrame
  {
  private JButton    mCancelButton;
  private JButton    mOKButton;
  private JTextField mInputTextField;
  private JLabel     mNameLabel;
  private JCheckBox  mFirstNameCheckBox;
  private JCheckBox  mLastNameCheckBox;
  private JPanel     mCheckPanel;
  private JPanel     mButtonPanel;
  
  public FXOne()
    {
    super ("Input Name");
    mNameLabel      = new JLabel("Type your name");
    mInputTextField = new JTextField(20);
    setLayout(new FlowLayout());
    mOKButton = new JButton("ok");
    mCancelButton = new JButton("Cancel");
    mButtonPanel  = new JPanel();
    mButtonPanel.setLayout(new GridLayout(1,2));
    mButtonPanel.add(mOKButton);
    mButtonPanel.add(mCancelButton);
    add      (mNameLabel);
    add      (mInputTextField);
    add      (mButtonPanel);
    }
  
  public static void main(String args[])
    {
    FXOne f = new FXOne();
    f.setLayout(new FlowLayout(FlowLayout.RIGHT, 10, 5));
    f.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    f.setSize(400,150);
    f.setVisible(true);
    }
  }