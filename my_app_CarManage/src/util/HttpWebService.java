/**
 * 功能	访问服务器Web Service
 */
package util;

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

public class HttpWebService implements Runnable {	
	public String data = "";	//接收数据
	private String methodName = "";	//方法名
	private ArrayList<String> Parameters = new ArrayList<String>();	//参数名
	private ArrayList<String> ParValues = new ArrayList<String>();	//参数
	
	/**
	 * 功能	给变量赋值
	 * @param methodName
	 * @param Parameters
	 * @param ParValues
	 */
	public void GetWebServre(String methodName, ArrayList<String> Parameters, ArrayList<String> ParValues) 
	{ 
		this.methodName = methodName;
		this.Parameters = Parameters;
		this.ParValues = ParValues;
	} 

	@Override
	public void run() {
		// TODO 自动生成的方法存根
        //ServerUrl是指webservice的url  
        //10.0.2.2是让android模拟器访问本地（PC）服务器，不能写成127.0.0.1  
        //11125是指端口号，即挂载到IIS上的时候开启的端口  
        //Service1.asmx是指提供服务的页面  
        
    	String ServerUrl = HttpURL.ServerUrl;  
//        String methodName = "selectAllCargoInfor";
//        Parameters.add("Carid");
//        ParValues.add("2");
        
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

            data = "";
	        for (int i = 0; i < nodeList.getLength(); i++) {
	        	data = data + nodeList.item(i).getFirstChild().getNodeValue() + "#" ;
	        }
	        
	        System.out.println("8888：" + data);
	        
        } catch (Exception e) {  
            System.out.print("2221");   
        }  
	}

}
