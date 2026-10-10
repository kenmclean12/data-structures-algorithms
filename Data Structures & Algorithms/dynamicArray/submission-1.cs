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
       int num = array[arraySize - 1];
       array[arraySize - 1] = 0;
       arraySize--;
       return num;
    }

    private void Resize() {
        int[] newArr = new int[array.Length * 2];
        Array.Copy(array, newArr, arraySize);
        array = newArr;
    }

    public int GetSize() {
        return arraySize;
    }

    public int GetCapacity() {
        return array.Length;
    }
}
