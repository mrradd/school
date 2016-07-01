
/*******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Post Lab5 Assignment - Distance
* 20160629
*******************************************************************************/
package rad;

/*******************************************************************************
* Class Vec2 */
/**
* Vector with two components. Can represent a point in 2Space.
*******************************************************************************/
class Vec2
  {
  private double mX;
  private double mY;

  /*****************************************************************************
  * Vec2 */
  /**
  * Calculate distance between to Vec2 objects.
  * 
  * @param  x  X coordinate.
  * @param  y  Y coordinate.
  *****************************************************************************/
  public Vec2(double x, double y)
    {
    mX = x;
    mY = y;
    }
  
  /*****************************************************************************
  * distance */
  /**
  * Calculate distance between to Vec2 objects.
  * 
  * @param  vec  Vec2 object.
  *****************************************************************************/  
  public void distance(Vec2 vec)
    {
    double dx = Math.pow(vec.mX - mX, 2);
    double dy = Math.pow(vec.mY - mY, 2);
    System.out.println(Math.sqrt( dx - dy ));
    }
  }