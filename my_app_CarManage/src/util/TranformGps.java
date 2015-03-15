/**
 * 功能  GPS标准化
 */
package util;

import java.text.DecimalFormat;

public class TranformGps {
	
	/*	
	 * GPS标准化
	 */
/*	public double TranformNum1(String Num) {

	    String first = "";
	    String middle = "";
	    String stern = "";

	    first=Num.substring(0,2);
   	    middle=Num.substring(2,4);
   	    stern=Num.substring(5,7);

	    double First=Double.parseDouble(first);
	    double Middle=Double.parseDouble(middle);
	    double Stern=Double.parseDouble(stern);

	    double post = First + (Middle/60) + (Stern/3600);	  	    
		
		return post;
	}
	
	public double TranformNum2(String Num) {

	    String first = "";
	    String middle = "";
	    String stern = "";

	    first=Num.substring(0,3);
   	    middle=Num.substring(3,5);
   	    stern=Num.substring(6,8);

	    double First=Double.parseDouble(first);
	    double Middle=Double.parseDouble(middle);
	    double Stern=Double.parseDouble(stern);

	    double post = First + (Middle/60) + (Stern/3600);	  	    
		
		return post;
	}*/
	
	/*	
	 * GPS标准化
	 */	
	public double TranformNum1(String Num) {
		
	    int length=Num.length()-1;

	    String first = "";
	    String middle = "";

	    first=Num.substring(0,2);
   	    middle=Num.substring(2,length);

	    double First=Double.parseDouble(first);
	    double Middle=Double.parseDouble(middle);

	    DecimalFormat df1 = new DecimalFormat("0.000000");
	    double post = First + Double.parseDouble(df1.format(Middle/60));	  	    
		
		return post;
	}
	
	public double TranformNum2(String Num) {
		
	    int length=Num.length()-1;

	    String first = "";
	    String middle = "";

	    first=Num.substring(0,3);
   	    middle=Num.substring(3,length);

	    double First=Double.parseDouble(first);
	    double Middle=Double.parseDouble(middle);

	    DecimalFormat df1 = new DecimalFormat("0.000000");
	    double post = First + Double.parseDouble(df1.format(Middle/60));	  	    
		
		return post;
	}

}
