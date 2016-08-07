/*******************************************************************************
* Conrad Horton
* CSC275
* Asgn 3.1 Boost Setup
* 08/2/2016
* 
* Install Boost, and run the below code to test it out.
*******************************************************************************/
#include <boost/lambda/lambda.hpp>
#include <iostream>
#include <iterator>
#include <algorithm>

int main()
{
    using namespace boost::lambda;
    typedef std::istream_iterator<int> in;
    std::cout << "derp" << std::endl;
    std::for_each(
        in(std::cin), in(), std::cout << (_1 * 3) << " " );
}