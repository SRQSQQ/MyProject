/**
 * ����ʱ���������
 */
package tool;

public class TimeJL {
	public String jingluo = "";
	
	public String TimeJingLuo(String time) {
		if (time.equals("��ʱ")) {	//��ʱ��Ӧ����
			jingluo = "����";
		} else if (time.equals("��ʱ")) {	//��ʱ��Ӧ�ξ�
			jingluo = "�ξ�";
		} else if (time.equals("��ʱ")) {	//��ʱ��Ӧ�ξ�
			jingluo = "�ξ�";
		} else if (time.equals("îʱ")) {	//îʱ��Ӧ�󳦾�
			jingluo = "�󳦾�";
		} else if (time.equals("��ʱ")) {	//��ʱ��Ӧθ��
			jingluo = "θ��";
		} else if (time.equals("��ʱ")) {	//��ʱ��ӦƢ��
			jingluo = "Ƣ��";
		} else if (time.equals("��ʱ")) {	//��ʱ��Ӧ�ľ�
			jingluo = "�ľ�";
		} else if (time.equals("δʱ")) {	//δʱ��ӦС����
			jingluo = "С����";
		} else if (time.equals("��ʱ")) {	//��ʱ��Ӧ���׾�
			jingluo = "���׾�";
		} else if (time.equals("��ʱ")) {	//��ʱ��Ӧ����
			jingluo = "����";
		} else if (time.equals("��ʱ")) {	//��ʱ��Ӧ�İ���
			jingluo = "�İ���";
		} else if (time.equals("��ʱ")) {	//��ʱ��Ӧ������
			jingluo = "������";
		}
		return jingluo;
	}
}
