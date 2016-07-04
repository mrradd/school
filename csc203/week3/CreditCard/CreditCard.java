
/*******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Assignment Credit Card Validator
* 20160703
*******************************************************************************/
package rad;

class CreditCard
  {
  private String  mCardNumber = "";

  /*****************************************************************************
  /* CTOR */
  /**
  * @param  cardNumber  Credit card's number.
  *****************************************************************************/
  public CreditCard(long cardNumber)
    {
    mCardNumber = String.valueOf(cardNumber);
    }

  /*****************************************************************************
  /* checkType */
  /**
  * Checks the card type by checking prefix. 
  *****************************************************************************/
  public String checkType()
    {
    String type = "Unknown";
    if(mCardNumber.startsWith("4"))
      type = "Visa";
    else if(mCardNumber.startsWith("5"))
      type = "MasterCard";
    else if(mCardNumber.startsWith("6"))
      type = "Amex";
    else if(mCardNumber.startsWith("37"))
      type = "Discover";
    
    return type;
    }

  /*****************************************************************************
  /* getDigit */
  /**
  * Sum of tens and ones places of a double digit number.
  *****************************************************************************/
  public int getDigit(int num){ return num/10 + num%10; }

  /*****************************************************************************
  /* isValid */
  /**
  * Checks card's validity by checking length of number, and Luhn Check.
  *****************************************************************************/
  public boolean isValid()
    {
    boolean type   = !checkType().equals("Unknown");
    boolean length = mCardNumber.length() >= 13 && mCardNumber.length() <= 16;
    boolean sum    = (sumDoubleEvens() + sumOfOdds()) % 10 == 0;
    return type && length && sum;
    }
  
  /*****************************************************************************
  /* sumDoubleEvens */
  /**
  * Double every even digit from right to left. If over 9, add single digits
  * together. Sum digits together that were generated this way.
  * @return  Sum of doubled even digits.
  *****************************************************************************/
  public int sumDoubleEvens()
    {
    int sum = 0;
    for (int i = mCardNumber.length() - 2; i >= 0; i -= 2)
      {
      int num = Integer.parseInt(mCardNumber.substring(i, i+1));
      if ((num * 2) < 10)
        sum += (num * 2);
      else
        sum += getDigit(num*2);
      }
    
    return sum;
    }

  /*****************************************************************************
  /* sumOfOdds */
  /**
  * Get the sum of all odd digits in odd position from right to left.
  * @return  Sum of all odd digits.
  *****************************************************************************/
  public int sumOfOdds()
    {
    int sum = 0;
    int num = 0;
    for (int i = mCardNumber.length() - 1; i >= 0; i -= 2)
      {
      num = Integer.parseInt(mCardNumber.substring(i, i+1));
      sum += num;
      }
    return sum;
    }
  }



