/**
 * 
 */
package com.alternativagame.resource.utils.psd.section;

import java.io.DataInputStream;
import java.io.IOException;
import java.util.HashMap;
import java.util.Map;

import com.alternativagame.resource.utils.psd.IRBConstants;
import com.alternativagame.resource.utils.psd.irb.SlicesIRB;
import com.alternativagame.resource.utils.psd.types.B4String;

/**
 * –есурсы дл€ картинок
 * 
 * @author  виринг ј.¬ (arts80)
 * 
 */
public class PSDImageResources {

    private final Map<Integer, Object> irbs = new HashMap<Integer, Object>();

    public PSDImageResources(DataInputStream in) throws IOException {
	int size = in.readInt();
	int readedSize = 0;
	while (readedSize < size) {
	    // ostype
	    readedSize += 4;
	    B4String osType = new B4String(in);
	    // смотрим ресурс или нет, возможно надо просто пропустить участок
	    // файла
	    assert osType.getValue().equals("8BIM");

	    // id
	    int id = in.readUnsignedShort();
	    readedSize += 2;
	    // name
	    int length = in.readUnsignedByte();
	    readedSize++;
	    // сдвиг по четности
	    length = (length % 2) == 0 ? 1 : length;
	    readedSize += length;
	    byte[] name_byte = new byte[length];
	    in.read(name_byte);
	    String name = new String(name_byte);

	    // размер IRB
	    int sizeIRB = in.readInt();
	    readedSize += 4;
	    // читаем конкретный IRB
	    makeIRB(sizeIRB, id, in);
	    // сдвигаем размер
	    readedSize += sizeIRB;
	    // сдвиг по четности
	    if (sizeIRB % 2 == 1) {
		if (in.available() >= 1) {
		    in.readByte();
		    readedSize++;
		}
	    }

	}
    }

    /**
     * —формировать IRB блок
     * 
     * @param id
     * @param in
     * @throws IOException
     */
    private void makeIRB(int size, int id, DataInputStream in) throws IOException {
	int current = in.available();
	switch (id) {
	case IRBConstants.SLICES:
	    irbs.put(IRBConstants.SLICES, new SlicesIRB(in));
	    break;

	default:
	    in.skipBytes(size);
	    break;
	}

	// пропускаем, пока особо не пон€тно что там хранитс€
	in.skip(in.available() - (current - size));
    }

    /**
     * ѕолучить IRB ресурс
     * 
     * @param type
     * @return
     */
    public Object getIRB(int type) {
	assert irbs.containsKey(type);
	return irbs.get(type);
    }
}
