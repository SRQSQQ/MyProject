/**
 * 通过时间换算古代时辰
 */
package tool;

public class Ancient {
	String shichen = "";
	
	//根据系统时间算出古代时辰
	public String convertTime(String hour) {
		
		if (hour.equals("23") || hour.equals("0")) {	//子时
			shichen = "子时";
		}else if (hour.equals("1") || hour.equals("2")) {	//丑时
			shichen = "丑时";
		}else if (hour.equals("3") || hour.equals("4")) {	//寅时
			shichen = "寅时";
		}else if (hour.equals("5") || hour.equals("6")) {	//卯时
			shichen = "卯时";
		}else if (hour.equals("7") || hour.equals("8")) {	//辰时
			shichen = "辰时";
		}else if (hour.equals("9") || hour.equals("10")) {	//巳时
			shichen = "巳时";
		}else if (hour.equals("11") || hour.equals("12")) {	//午时
			shichen = "午时";
		}else if (hour.equals("13") || hour.equals("14")) {	//未时
			shichen = "未时";
		}else if (hour.equals("15") || hour.equals("16")) {	//申时
			shichen = "申时";
		}else if (hour.equals("17") || hour.equals("18")) {	//酉时
			shichen = "酉时";
		}else if (hour.equals("19") || hour.equals("20")) {	//戌时
			shichen = "戌时";
		}else if (hour.equals("21") || hour.equals("22")) {	//亥时
			shichen = "亥时";
		}		
		
		return shichen;
	}
}
