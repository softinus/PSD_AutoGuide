/**
 * 
 */
package com.alternativagame.resource.utils.psd.images;

import java.io.DataInputStream;
import java.io.IOException;

/**
 * ������ RLE ����������� ������ ����
 * 
 * @author ������� �.� (arts80)
 * 
 */
public class RAWParser {

    byte[] result = null;

    /**
     * @param bounds
     * @param in
     * @throws IOException
     */
    public RAWParser(int width, int heigth, DataInputStream in) throws IOException {
	result = new byte[width * heigth];
	in.read(result);
    }

    /**
     * ���������
     * 
     * @return
     */
    public byte[] getData() {
	return result;
    }
}
