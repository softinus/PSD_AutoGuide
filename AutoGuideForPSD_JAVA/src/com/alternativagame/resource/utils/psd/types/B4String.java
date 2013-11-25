/**
 * 
 */
package com.alternativagame.resource.utils.psd.types;

import java.io.DataInputStream;
import java.io.IOException;

/**
 * Сигнатура (4-байта, строка)
 * 
 * @author Квиринг А.В (arts80)
 * 
 */
public class B4String {

    private final String value;

    /**
     * @param in
     * @throws IOException
     */
    public B4String(DataInputStream in) throws IOException {
	byte[] data = new byte[4];
	in.read(data);
	value = new String(data);
    }

    public String getValue() {
	return value;
    }

    /*
     * (non-Javadoc)
     * 
     * @see java.lang.Object#toString()
     */
    @Override
    public String toString() {
	return value;
    }

}
