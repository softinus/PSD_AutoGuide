/**
 * 
 */
package com.alternativagame.resource.utils.psd.section;

import java.io.DataInputStream;
import java.io.IOException;

/**
 * Color mode data section
 * 
 * @author Квиринг А.В (arts80)
 * 
 */
public class PSDColorMode {

    public PSDColorMode(DataInputStream in) throws IOException {
	int size = in.readInt();
	in.skipBytes(size);
    }

}
