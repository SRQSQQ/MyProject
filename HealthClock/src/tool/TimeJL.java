/**
 * 根据时间算出经络
 */
package tool;

public class TimeJL {
	public String jingluo = "";
	
	public String TimeJingLuo(String time) {
		if (time.equals("子时")) {	//子时对应胆经
			jingluo = "胆经";
		} else if (time.equals("丑时")) {	//丑时对应肝经
			jingluo = "肝经";
		} else if (time.equals("寅时")) {	//寅时对应肺经
			jingluo = "肺经";
		} else if (time.equals("卯时")) {	//卯时对应大肠经
			jingluo = "大肠经";
		} else if (time.equals("辰时")) {	//辰时对应胃经
			jingluo = "胃经";
		} else if (time.equals("巳时")) {	//巳时对应脾经
			jingluo = "脾经";
		} else if (time.equals("午时")) {	//午时对应心经
			jingluo = "心经";
		} else if (time.equals("未时")) {	//未时对应小肠经
			jingluo = "小肠经";
		} else if (time.equals("申时")) {	//申时对应膀胱经
			jingluo = "膀胱经";
		} else if (time.equals("酉时")) {	//酉时对应肾经
			jingluo = "肾经";
		} else if (time.equals("戌时")) {	//戌时对应心包经
			jingluo = "心包经";
		} else if (time.equals("亥时")) {	//亥时对应三焦经
			jingluo = "三焦经";
		}
		return jingluo;
	}
}
