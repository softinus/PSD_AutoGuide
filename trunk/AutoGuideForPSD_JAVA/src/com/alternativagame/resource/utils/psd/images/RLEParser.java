/**
 * 
 */
package com.alternativagame.resource.utils.psd.images;

import java.io.DataInputStream;
import java.io.IOException;

import com.alternativagame.resource.utils.psd.images.unpacker.RLEPackBits;

/**
 * Парсер RLE изображений одного слоя
 * 
 * @author Квиринг А.В (arts80)
 * 
 */
public class RLEParser {

    byte[] result = null;

    /**
     * @param bounds
     * @param in
     * @throws IOException
     */
    public RLEParser(int width, int heigth, DataInputStream in) throws IOException {

	// результат
	result = new byte[width * heigth];

	int[] sizeScanLines = new int[heigth];
	// определяем размеры каждой линии

	// читаем размеры линий

	int allSize = 0;
	for (int i = 0; i < heigth; i++) {
	    sizeScanLines[i] = in.readUnsignedShort();
	    allSize += sizeScanLines[i];
	}

	// а теперь парсим кажду линию
	for (int i = 0; i < heigth; i++) {
	    // читаем данные
	    int sizeScanLine = sizeScanLines[i];
	    byte[] data = new byte[sizeScanLine];
	    in.read(data);
	    RLEPackBits packBits = new RLEPackBits(data, width);
	    byte[] line = packBits.unpack();
	    System.arraycopy(line, 0, result, i * width, line.length);
	}

    }

    /**
     * Результат
     * 
     * @return
     */
    public byte[] getData() {
	return result;
    }
}
