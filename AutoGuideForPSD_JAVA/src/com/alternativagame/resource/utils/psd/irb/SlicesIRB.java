/**
 * 
 */
package com.alternativagame.resource.utils.psd.irb;

import java.io.DataInputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import com.alternativagame.resource.utils.psd.types.Rect;
import com.alternativagame.resource.utils.psd.types.VString;

/**
 * @author Квиринг А.В (arts80)
 * 
 */
public class SlicesIRB {

    private Rect bounding;

    private VString name;

    private int count;

    private final List<Slice> slices = new ArrayList<Slice>();

    public SlicesIRB(DataInputStream in) throws IOException {

	// парсим заголовок
	parseHeader(in);
	// парсим слайды
	for (int i = 0; i < count; i++) {
	    Slice slice = new Slice(in);
	    this.slices.add(slice);
	}

    }

    private void parseHeader(DataInputStream in) throws IOException {
	// версия
	int version = in.readInt();
	// BoundingBox
	bounding = new Rect(in);
	// Наименование
	name = new VString(in);
	// количество слайсов
	count = in.readInt();

    }

    /**
     * Получить список слайсов
     * 
     * @return
     */
    public List<Slice> getSlices() {
	return slices;
    }

}
