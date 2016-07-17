
package rad;

/*******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Inheritance and Polymorphism Lab
* 20160716
*******************************************************************************/
public class PieceWorker extends Employee
  {
  private double mWage;
  private double mPieces;
  
  /*****************************************************************************
  * CTOR */
  /**
  * @param  firstName             Employee first name.
  * @param  lastName              Employee last name.
  * @param  socialSecurityNumber  Employee social security number.
  * @param  wage                  Employee wage per piece.
  *****************************************************************************/
  public PieceWorker(String firstName, String lastName,
    String socialSecurityNumber, double wage)
    {
    super(firstName, lastName, socialSecurityNumber);                      
    
    setWage(wage);
    }

  /** Get/Set pieces produced. **/
  public double getPiecesProduced()
    {
    return mPieces;
    }
  public void setPiecesProduced(double pieces)
    {
    if (pieces < 0.0)                   
      throw new IllegalArgumentException("Wage must be >= 0.0");  
    else
      mPieces = pieces;              
    }
  
  /** Get/Set wage. **/
  public double getWage()
    {
    return mWage;
    }
  public void setWage(double wage)
    {
    if (wage < 0.0)                   
      throw new IllegalArgumentException("Wage must be >= 0.0");  
    else
      mWage = wage;              
    }
  
  /** Get earnings. **/
  public double earnings()
    {
    return mWage * mPieces;
    }

  public String toString()
    {
    return String.format("%s %s%n%s: %.2f\n%s: %.2f\n%s: %.2f", "base-salaried",
      super.toString(), "wage", mWage, "pieces produced", mPieces,
      "earned", earnings());   
    }
  
  }
