/**
 * 功能	超额温度界面
 */
package user;


import java.io.InputStream;
import java.io.OutputStream;
import java.net.HttpURLConnection;
import java.net.URL;
import java.util.ArrayList;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;

import util.HttpURL;
import util.HttpWebService;

import com.example.my_app_carmanage.R;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class DiscrepancyActivity extends BaseActivity implements Runnable{

	HttpWebService httpWebService = new HttpWebService();
	public static String Temperature = "";
	public static String Time = "";
	public TextView txt_temperature2;
	public TextView txt_time2;
	public TextView txt_state;
	public Button btn_state;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		// TODO Auto-generated method stub
		super.onCreate(savedInstanceState);
		setContentView(R.layout.monitoring_discrepancy);			    			
		
        try {
        	Thread.sleep(500);
        	
        	txt_temperature2 = (TextView)findViewById(R.id.txt_temperature2);
        	txt_time2 = (TextView)findViewById(R.id.txt_time2);
			txt_state = (TextView)findViewById(R.id.txt_state);
			
			btn_state = (Button)findViewById(R.id.btn_state);
			btn_state.setOnClickListener(new View.OnClickListener() {
				
				@Override
				public void onClick(View v) {
					txt_temperature2.setText(Temperature);
					txt_time2.setText(Time);
		 	        
		 	        if (txt_temperature2.getText().equals("") || Temperature.equals("")) {
		 	        	txt_state.setText("您好！没有超额温度！请您放心！");
					}
				}
			});
			
			
		} catch (InterruptedException e) {
			// TODO 自动生成的 catch 块
			e.printStackTrace();
		}
	}
	
    public void run() {      
        //ServerUrl是指webservice的url  
        //10.0.2.2是让android模拟器访问本地（PC）服务器，不能写成127.0.0.1  
        //11125是指端口号，即挂载到IIS上的时候开启的端口  
        //Service1.asmx是指提供服务的页面  
        
    	String ServerUrl = HttpURL.ServerUrl;  
        String methodName = "notState";
        ArrayList<String> Parameters = new ArrayList<String>();
        ArrayList<String> ParValues = new ArrayList<String>();
        Parameters.add("TemperatureMax");
        ParValues.add(AlarmActivity.TMax);
        Parameters.add("TemperatureMin");
        ParValues.add(AlarmActivity.TMin);
        
        //String soapAction="http://tempuri.org/LongUserId1";  
        String soapAction = "http://tempuri.org/" + methodName;  
        //String data = "";  
        String soap = "<?xml version=\"1.0\" encoding=\"utf-8\"?>"  
                + "<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">"  
                + "<soap:Body />";  
        String tps, vps, ts;  
        String mreakString = "";  
  
        mreakString = "<" + methodName + " xmlns=\"http://tempuri.org/\">";  
        for (int i = 0; i < Parameters.size(); i++) {  
            tps = Parameters.get(i).toString();  
            //设置该方法的参数为.net webService中的参数名称  
            vps = ParValues.get(i).toString();  
            ts = "<" + tps + ">" + vps + "</" + tps + ">";  
            mreakString = mreakString + ts;  
        }  
        mreakString = mreakString + "</" + methodName + ">";  
        /* 
        +"<HelloWorld xmlns=\"http://tempuri.org/\">" 
        +"<x>string11661</x>" 
        +"<SF1>string111</SF1>" 
        + "</HelloWorld>" 
        */  
        String soap2 = "</soap:Envelope>";  
        String requestData = soap + mreakString + soap2;  
        //System.out.println(requestData);  
  
        try {  
            URL url = new URL(ServerUrl);  
            HttpURLConnection con = (HttpURLConnection) url.openConnection();  
            byte[] bytes = requestData.getBytes("utf-8");  
            con.setDoInput(true);  
            con.setDoOutput(true);  
            con.setUseCaches(false);  
            con.setConnectTimeout(6000);// 设置超时时间  
            con.setRequestMethod("POST");  
            con.setRequestProperty("Content-Type", "text/xml;charset=utf-8");  
            con.setRequestProperty("SOAPAction", soapAction);  
            con.setRequestProperty("Content-Length", "" + bytes.length);  
            OutputStream outStream = con.getOutputStream();  
            outStream.write(bytes);  
            outStream.flush();  
            outStream.close();  
            InputStream inStream = con.getInputStream();
            
            
            DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
            DocumentBuilder builder = null ;
            Document document = null ;
            
            builder = factory.newDocumentBuilder();
            document = builder.parse(inStream);
            Element root = document.getDocumentElement();
            NodeList nodeList = root.getElementsByTagName("string");
            
            Time = "";
            Temperature = "";
 	        for (int i = 0; i < nodeList.getLength(); i++) {
 	        	if (nodeList.item(i).getFirstChild().getNodeValue().length() > 10) {
 	        		Time = Time + nodeList.item(i).getFirstChild().getNodeValue() + "\n";
				} else {
					Temperature = Temperature + nodeList.item(i).getFirstChild().getNodeValue() + "℃"+ "/" + 30 + "℃" + "\n";
				}
 	        }        	         	      
     } catch (Exception e) {  
            System.out.print("2221");   
        }  
    }
}
