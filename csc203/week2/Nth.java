
/***
Conrad Horton
CSC203 Jun2016
Post Lab3 Assignment
20160620
***/

class Nth
  {
  public static void main (String[] args)
    {
    System.out.println( "N\t10*N\t100*N\t1000*N\n" );
    for (int i = 1; i <= 5; i++)
      {
      System.out.printf( "%d\t %d\t %d\t %d\n", i , i * 10, i * 100, i * 1000 );
      }
    }
  }