
package rad;

/*******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Inheritance and Polymorphism Lab
* 20160716
*******************************************************************************/
public class BasePlusCommissionEmployee
  {
  private double             mBaseSalary;
  private CommissionEmployee mCE;

  /*****************************************************************************
  * CTOR */
  /**
  * @param  firstName             Employee first name.
  * @param  lastName              Employee last name.
  * @param  socialSecurityNumber  Employee social security number.
  * @param  grossSales            Gross sales of employee.
  * @param  commissionRate        Commission rate of employee.
  * @param  baseSalary            Employee's base salary.
  *****************************************************************************/
  public BasePlusCommissionEmployee(String firstName, String lastName,
    String socialSecurityNumber, double grossSales,
    double commissionRate, double baseSalary)
    {
    mCE = new CommissionEmployee(firstName, lastName,
      socialSecurityNumber, grossSales, commissionRate);                      
    
    
    if (baseSalary < 0.0)             
      throw new IllegalArgumentException("Base salary must be >= 0.0");

    mBaseSalary = baseSalary;
    }

  /** Get/Set Base salary. **/
  public double getBaseSalary()
    {
    return mBaseSalary;
    }
  public void setBaseSalary(double baseSalary)
    {
    if (baseSalary < 0.0)                   
      throw new IllegalArgumentException("Base salary must be >= 0.0");  

    mBaseSalary = baseSalary;                
    }
  
  /** Get/Set commision rate. **/
  public double getCommissionRate()
    {
    return mCE.getCommissionRate();
    }
  public void setCommissionRate(double commissionRate)
    {
    mCE.setCommissionRate(commissionRate);
    }
  
  /** Get/Set first name. **/
  public String getFirstName()
    {
    return mCE.getFirstName();
    }
  public void setFirstName(String firstName)
    {
    mCE.setFirstName(firstName);
    }
  
  /** Get/Set gross sales. **/
  public double getGrossSales()
    {
    return mCE.getGrossSales();
    }
  public void setGrossSales(double grossSales)
    {
    mCE.setGrossSales(grossSales);
    }
  
  /** Get/Set last name. **/
  public String getLastName()
    {
    return mCE.getLastName();
    }
  public void setLastName(String lastName)
    {
    mCE.setLastName(lastName);
    }

  /** Get/Set SSN. **/
  public String getSSN()
    {
    return mCE.getSocialSecurityNumber();
    }
  public void setSSN(String ssn)
    {
    mCE.setSocialSecurityNumber(ssn);
    }
  
  /** Get earnings. **/
  public double earnings()
    {
    return getBaseSalary() + mCE.earnings();
    }

  public String toString()
    {
    return String.format("%s %s%n%s: %.2f", "base-salaried",
      super.toString(), "base salary", getBaseSalary());   
    }
  
  }
