public class DynamicArray {
    private int[] array;
    private int arraySize;

    public DynamicArray(int capacity) {
        array = new int[capacity];
    }

    public int Get(int i) {
        return array[i];
    }

    public void Set(int i, int n) {
        array[i] = n;
    }

    public void PushBack(int n) {
        if (arraySize == array.Length) Resize();
        array[arraySize] = n;
        arraySize++;
    }

    public int PopBack() {
        int last = array[arraySize - 1];
        array[arraySize - 1] = 0;
        arraySize--;
        return last;
    }

    private void Resize() {
        int[] newArray = new int[array.Length * 2];
        Array.Copy(array, newArray, arraySize);
        array = newArray;
    }

    public int GetSize() {
        return arraySize;
    }

    public int GetCapacity() {
        return array.Length;
    }
}
