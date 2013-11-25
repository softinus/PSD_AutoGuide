/**
 * 
 */
package com.alternativagame.resource.utils.psd.section;

import java.io.DataInputStream;
import java.io.IOException;

import com.alternativagame.resource.utils.psd.types.B4String;

/**
 * Заголовок PSD файла
 * 
 * @author Квиринг А.В (arts80)
 * 
 */
public class PSDHeader {
    private final B4String signature;

    private final int version;

    private final int channel;

    private final int rows;

    private final int columns;

    private final int depth;

    private final int mode;

    public PSDHeader(DataInputStream in) throws IOException {
	// читаем сигнатуру
	signature = new B4String(in);
	// версия
	version = in.readUnsignedShort();
	// 6 байт резерва
	in.skipBytes(6);
	// количество каналов
	channel = in.readUnsignedShort();
	// размеры
	rows = in.readInt();
	columns = in.readInt();
	// глубина цвета
	depth = in.readUnsignedShort();
	// режим
	mode = in.readUnsignedShort();
    }

    public B4String getSignature() {
	return signature;
    }

    public int getVersion() {
	return version;
    }

    public int getChannel() {
	return channel;
    }

    public int getRows() {
	return rows;
    }

    public int getColumns() {
	return columns;
    }

    public int getDepth() {
	return depth;
    }

    public int getMode() {
	return mode;
    }

    /*
     * (non-Javadoc)
     * 
     * @see java.lang.Object#toString()
     */
    @Override
    public String toString() {
	StringBuilder builder = new StringBuilder();
	builder.append("Signature:").append(signature).append('\n');
	builder.append("Version:").append(version).append('\n');
	builder.append("Channel:").append(channel).append('\n');
	builder.append("Rows:").append(rows).append('\n');
	builder.append("Columns:").append(columns).append('\n');
	builder.append("Depth:").append(depth).append('\n');
	builder.append("Mode:").append(mode).append('\n');
	return builder.toString();
    }
}
