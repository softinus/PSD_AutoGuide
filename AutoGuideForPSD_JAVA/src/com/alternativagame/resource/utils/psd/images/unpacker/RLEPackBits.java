/**
 * 
 */
package com.alternativagame.resource.utils.psd.images.unpacker;

/**
 * RLE PackBits распаковщик
 * 
 * @author Квиринг А.В (arts80)
 * 
 */
public class RLEPackBits {

    private final byte[] data;

    private final int size;

    public RLEPackBits(byte[] data, int size) {
	this.data = data;
	this.size = size;
    }

    public byte[] unpack() {
	byte[] result = new byte[size];

	// позиция записи
	int writePos = 0;
	// позиция чтения
	int readPos = 0;
	// читаем
	while (readPos < data.length) {
	    // читаем байт
	    int n = data[readPos++];

	    if (n > 0) {
		// копируем строку байт
		int count = n + 1;
		for (int j = 0; j < count; j++)
		    result[writePos++] = data[readPos++];
	    } else {
		// копируем следующий байт n раз
		byte b = data[readPos++];
		int count = -n + 1;
		for (int j = 0; j < count; j++)
		    result[writePos++] = b;
	    }
	}

	return result;
    }

}
