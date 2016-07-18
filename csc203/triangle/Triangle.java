
/*******************************************************************************
* Conrad Horton
* CISC203 June 2016
* Triangle
* 20170717
*******************************************************************************/

package rad;

/*******************************************************************************
* Class Triangle */
/**
* Represents a Triangle.
*******************************************************************************/
class Triangle extends GeometricObject 
  {
  private double mSide1;
  private double mSide2;
  private double mSide3;
  
  public Triangle() { this(0,0,0); }
  public Triangle(double a, double b, double c)
    {
    super();
    mSide1 = a;
    mSide2 = b;
    mSide3 = c;
    }
  
  /** Abstract method getArea assuming using Heron's formula. */
  public double getArea()
    {
    double p        = getPerimeter()/2;
    double radicand = p*(p-mSide1)*(p-mSide2)*(p-mSide3);
    return Math.sqrt(radicand);
    }

  /** Abstract method getPerimeter */
  public  double getPerimeter() { return mSide1 + mSide2 + mSide3; }
  
  public String toString()
    {
    return "Triangle: side1 = " + mSide1 + " side2 = " + mSide2 + " side3 = " + mSide3;
    }
  
  public static void main(String[] args)
    {    
    Triangle triangle = new Triangle(1, 1.5, 1);    
    triangle.setColor("yellow");    
    triangle.setFilled(true);     
    System.out.println(triangle);    
    System.out.println("The area is " + triangle.getArea()); System.out.println("The perimeter is " + triangle.getPerimeter());
    System.out.println(triangle);  
    }
  }