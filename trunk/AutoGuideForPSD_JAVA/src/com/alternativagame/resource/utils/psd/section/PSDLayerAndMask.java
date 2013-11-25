/**
 * 
 */
package com.alternativagame.resource.utils.psd.section;

import java.io.DataInputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

import com.alternativagame.resource.utils.psd.layer.PSDLayerPixelData;
import com.alternativagame.resource.utils.psd.layer.PSDLayerStructure;

/**
 * Слои PSD файла
 * 
 * @author Квиринг А.В (arts80)
 * 
 */
public class PSDLayerAndMask {

    /**
     * Информация о слоях
     */
    private final List<PSDLayerStructure> layers = new ArrayList<PSDLayerStructure>();

    /**
     * Изображения слоев
     */
    private final List<PSDLayerPixelData> imageLayers = new ArrayList<PSDLayerPixelData>();

    public PSDLayerAndMask(DataInputStream in) throws IOException {
	int size = in.readInt();
	parseLayerInfo(in);
	parseLayerMask(in);
	in.skipBytes(size);
    }

    /**
     * @param in
     */
    private void parseLayerMask(DataInputStream in) {

    }

    /**
     * Парсим информацию о слоях
     * 
     * @param in
     * @throws IOException
     */
    private void parseLayerInfo(DataInputStream in) throws IOException {
	// размер в байтах секции Info
	int size = in.readInt();

	int countLayer = Math.abs(in.readShort());
	// Layer Structure
	for (int i = 0; i < countLayer; i++) {
	    PSDLayerStructure layer = new PSDLayerStructure(in);
	    this.layers.add(layer);

	}
	// Layer Pixel Data
	for (int i = 0; i < countLayer; i++) {
	    PSDLayerPixelData pixels = new PSDLayerPixelData(this.layers.get(i), in);
	    this.imageLayers.add(pixels);
	}

    }

    /**
     * Список слоев
     * 
     * @return
     */
    public List<PSDLayerStructure> getLayers() {
	return layers;
    }

    /**
     * Список изображений для слоев
     * 
     * @return
     */
    public List<PSDLayerPixelData> getImageLayers() {
	return imageLayers;
    }

}
