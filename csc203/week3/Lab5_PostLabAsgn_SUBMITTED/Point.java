
/*******************************************************************************
* Conrad Horton
* CSC203 June 2016
* Post Lab5 Assignment - Distance
* 20160629
*******************************************************************************/
package rad;

/*******************************************************************************
* Class Point */
/**
* Point with two components. Can represent a point in 2Space.
*******************************************************************************/
class Point
  {
  private double mX;
  private double mY;

  /*****************************************************************************
  * Point */
  /**
  * @param  x  X coordinate.
  * @param  y  Y coordinate.
  *****************************************************************************/
  public Point(double x, double y)
    {
    mX = x;
    mY = y;
    }
  
  /*****************************************************************************
  * distance */
  /**
  * Calculate distance between two Point objects. 
  * 
  * @param  p  Point object.
  *****************************************************************************/
  public double distance(Point p)
    {
    /** Distance = sq((x2 - x1)^2 + (y2 - y1)^2) **/
    return Math.sqrt(Math.pow(p.mX - mX, 2) + Math.pow(p.mY - mY, 2));
    }
  
  public static void main (String[] args)
    {
    Point v  = new Point(1, 1);
    Point v2 = new Point(2, 2);
    v.distance(v2);
    }
  }