/**
 * ���������������
 */
package tool;

public class DateJL {
	public String jingluo = "";
	
	public String DateJingLuo(String date) {
		if (date.equals("��")) {		//�׶�Ӧ����
			jingluo = "����";
		} else if (date.equals("��")) {	//�Ҷ�Ӧ�ξ�
			jingluo = "�ξ�";
		} else if (date.equals("��")) {	//����ӦС����
			jingluo = "С����";
		} else if (date.equals("��")) {	//����Ӧ�ľ�
			jingluo = "�ľ�";
		} else if (date.equals("��")) {	//���Ӧθ��
			jingluo = "θ��";
		} else if (date.equals("��")) {	//����ӦƢ��
			jingluo = "Ƣ��";
		} else if (date.equals("��")) {	//����Ӧ�󳦾�
			jingluo = "�󳦾�";
		} else if (date.equals("��")) {	//����Ӧ�ξ�
			jingluo = "�ξ�";
		} else if (date.equals("��")) {	//�ɶ�Ӧ���׾�
			jingluo = "���׾�";
		} else if (date.equals("��")) {	//���Ӧ����
			jingluo = "����";
		}
		return jingluo;
	}
}
