/**
 * ͨ��ʱ�任��Ŵ�ʱ��
 */
package tool;

public class Ancient {
	String shichen = "";
	
	//����ϵͳʱ������Ŵ�ʱ��
	public String convertTime(String hour) {
		
		if (hour.equals("23") || hour.equals("0")) {	//��ʱ
			shichen = "��ʱ";
		}else if (hour.equals("1") || hour.equals("2")) {	//��ʱ
			shichen = "��ʱ";
		}else if (hour.equals("3") || hour.equals("4")) {	//��ʱ
			shichen = "��ʱ";
		}else if (hour.equals("5") || hour.equals("6")) {	//îʱ
			shichen = "îʱ";
		}else if (hour.equals("7") || hour.equals("8")) {	//��ʱ
			shichen = "��ʱ";
		}else if (hour.equals("9") || hour.equals("10")) {	//��ʱ
			shichen = "��ʱ";
		}else if (hour.equals("11") || hour.equals("12")) {	//��ʱ
			shichen = "��ʱ";
		}else if (hour.equals("13") || hour.equals("14")) {	//δʱ
			shichen = "δʱ";
		}else if (hour.equals("15") || hour.equals("16")) {	//��ʱ
			shichen = "��ʱ";
		}else if (hour.equals("17") || hour.equals("18")) {	//��ʱ
			shichen = "��ʱ";
		}else if (hour.equals("19") || hour.equals("20")) {	//��ʱ
			shichen = "��ʱ";
		}else if (hour.equals("21") || hour.equals("22")) {	//��ʱ
			shichen = "��ʱ";
		}		
		
		return shichen;
	}
}
