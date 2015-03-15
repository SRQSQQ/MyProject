/*
 * UpdateInfo
 * 
 * 2014年11月10日
 * 
 * 宋润强
 * 
 * 存放更新信息
 */
package com.security.model;

public class UpdateInfo {
    private String version;
    private String description;
    private String url;
	public String getVersion() {
		return version;
	}
	public void setVersion(String version) {
		this.version = version;
	}
	public String getDescription() {
		return description;
	}
	public void setDescription(String description) {
		this.description = description;
	}
	public String getUrl() {
		return url;
	}
	public void setUrl(String url) {
		this.url = url;
	}	
}
