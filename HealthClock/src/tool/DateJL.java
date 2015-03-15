/**
 * 根据日期算出经络
 */
package tool;

public class DateJL {
	public String jingluo = "";
	
	public String DateJingLuo(String date) {
		if (date.equals("甲")) {		//甲对应胆经
			jingluo = "胆经";
		} else if (date.equals("乙")) {	//乙对应肝经
			jingluo = "肝经";
		} else if (date.equals("丙")) {	//丙对应小肠经
			jingluo = "小肠经";
		} else if (date.equals("丁")) {	//丁对应心经
			jingluo = "心经";
		} else if (date.equals("戊")) {	//戊对应胃经
			jingluo = "胃经";
		} else if (date.equals("己")) {	//己对应脾经
			jingluo = "脾经";
		} else if (date.equals("庚")) {	//庚对应大肠经
			jingluo = "大肠经";
		} else if (date.equals("辛")) {	//辛对应肺经
			jingluo = "肺经";
		} else if (date.equals("壬")) {	//壬对应膀胱经
			jingluo = "膀胱经";
		} else if (date.equals("癸")) {	//癸对应肾经
			jingluo = "肾经";
		}
		return jingluo;
	}
}
