
/*******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Post Classes and Objects Lab - Rectangle
* 20160706
*******************************************************************************/
package rad;

class Rectangle
  {
  private float mLength;
  private float mWidth;

  /** Setters/getters. **/
  public void  setLength(float l) { mLength = l >= 0.0f && l < 20.0f ? l : 1.0f; }
  public float getLength()        { return mLength; }
  public void  setWidth (float w) { mWidth  = w >= 0.0f && w < 20.0f ? w : 1.0f; }
  public float getWidth ()        { return mWidth; }

  /*****************************************************************************
  * area */
  /** 
  * Calculate area. A = L * W  
  *****************************************************************************/
  public float area()
    {
    return mLength * mWidth;
    }
  
  /*****************************************************************************
  * perimeter */
  /** 
  * Calculate perimeter P = 2L + 2W  
  *****************************************************************************/
  public float perimeter()
    {
    return 2*mLength + 2*mWidth;
    }
  
  public String toString()
    {
    String s = "Length: "    + mLength       + "\nWidth: " + mWidth +
               "\nPerimeter: " + perimeter() + "\nArea: "  + area();
    return s;
    }
  }
