/**
 * 
 */
package com.alternativagame.resource.utils.psd;

import java.awt.image.BufferedImage;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.StringTokenizer;

import javax.imageio.ImageIO;

import com.alternativagame.resource.utils.psd.layer.PSDLayerPixelData;
import com.alternativagame.resource.utils.psd.layer.PSDLayerStructure;
import com.alternativagame.resource.utils.psd.section.PSDLayerAndMask;

/**
 * @author 喝寮妖���(arts80)
 * 
 */
public class TestPSD
{

    public static void main(String[] args) throws IOException
    {
    	
		System.out.println("Please input PSD path : ");
	    Scanner sc= new Scanner(System.in);
	    String strFullPath= sc.next();
	    
	    File f = new File(strFullPath); 
	    String strFileName = f.getName(); 
	    String strFilePath = f.getParent();
	    
//	    StringTokenizer tok= new StringTokenizer(strFullPath, "\\");
//	    ArrayList<String> arrToken= new ArrayList<String>();
//	    
//	    while(tok.hasMoreTokens())
//	    {
//	    	arrToken.add( tok.nextToken() );
//	    }
//	    String strFileName= arrToken.get(tok.countTokens()-1);
	    
	    
	
	    PSDParser parser = new PSDParser(new FileInputStream(strFullPath));	// path 입력 
		//PSDParser parser = new PSDParser(new FileInputStream("H:\\psd_parser\\sample2.psd"));
		PSDLayerAndMask layerAndMask = parser.getLayerAndMask();
	
		List<PSDLayerStructure> layers = layerAndMask.getLayers();
		List<PSDLayerPixelData> images = layerAndMask.getImageLayers();
		
		BufferedWriter out= new BufferedWriter(new FileWriter(strFilePath+"\\"+strFileName+"_LayerInfo.txt"));
	    
		
		int i = 0;
		for (PSDLayerStructure layer : layers)
		{
		    PSDLayerPixelData pixelData = images.get(i);
		    BufferedImage image = pixelData.getImage();
		    
		    
		    File destFolder= new File(strFilePath + "\\"+ strFileName +"_Images\\");
		    if(!destFolder.exists())
		    {
		    	destFolder.mkdir();
		    }
		    //H:\psd_parser
		    
		    if (image != null)
		    	ImageIO.write(image, "png", new File(strFilePath + "\\"+ strFileName +"_Images\\"+ layer.getName() + ".png"));
		    
		    
		    int nX= layer.getBounds().getLeft();
		    int nY= layer.getBounds().getTop();
		    int nW= layer.getBounds().getRight();
		    int nH= layer.getBounds().getBottom();
		    
		    String strInfoX= String.valueOf( "X : " + nX );
		    String strInfoY= String.valueOf( "Y : " + nY );
		    String strInfoW= String.valueOf( "W : " + (nW-nX) );
		    String strInfoH= String.valueOf( "H : " + (nH-nY) );
		    
		    out.write(layer.getName().toString()); out.newLine();
		    out.write(strInfoX); out.newLine();
		    out.write(strInfoY); out.newLine();
		    out.write(strInfoW); out.newLine();
		    out.write(strInfoH); out.newLine();
		    
		    out.newLine();
	
		    i++;
		}
		
		 out.close();
	
		 System.out.println("완료");
    }
}
