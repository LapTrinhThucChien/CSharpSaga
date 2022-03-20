***ARRAY***

**Lý thuyết:**
- Array là một kiểu dữ liệu trong c# cho phép lưu trữ một tập hợp các giá trị. 
- Tham khảo cách sử dụng array: https://www.w3schools.com/cs/cs_arrays.php

**Bài tập:**

1. Cho một array có các phần tử là number. Duyệt qua array và in ra kết quả mỗi phần tử.

2. Cho một array có các phần tử là number. Tìm phần tử lớn nhất trong mảng.

Ví dụ: [4, 6, 2, 5] => kết quả: 6

3. Cho một array có các phần tử là number. Viết hàm đảo ngược array đó. (Lưu ý: array đảo ngược là array ban đầu, không được tạo ra array mới)

Ví dụ: [4, 6, 2, 5] => đảo ngược: [5, 2, 6, 4]

***COLLECTION AND GENERIC COLLECTION***

**1. Collection là gì?**

- Collection là các lớp trong c# hỗ trợ lưu trữ và làm việc với danh sách đối tượng.

- Các lớp này nằm trong namespace **System.Collections.**

- Tham khảo: https://docs.microsoft.com/en-us/dotnet/api/system.collections?view=net-6.0

- Một số collection phổ biến trong c# như: ArrayList, HashTable, SortedList, Stack, Queue, List.

**2. ArrayList**

**Lý thuyết:**
 ArrayList là gì:  Array là một collection trong c# giúp hỗ trợ lưu trữ và làm việc với danh sách đối tượng. 
Tương tự như Array có thể truy cập phần tử qua index nhưng linh hoạt hơn nhờ khả năng thêm, xóa phần tử và điều chỉnh kích thước một cách tự động.

 Nêu tác dụng của một số thuộc tính và phương thức của ArrayList dưới đây? 
- Count: 
- Add(Object): 
- AddRange(ICollection): 
- Clone(): 
- Insert(int Index, object Value): 
- Remove(object Value): 

Tham khảo: https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=net-6.0


**Bài tập ArrayList**

Tạo một Class Product chứa các thuộc tính: Id, Name, Description, Price.
Tạo ra 2 ArrayList để lưu danh sách Product: productArrayList1 và productArrayList2.
Yêu cầu: 
- Thêm 3 product bất kỳ vào productArrayList1 và 2 product bất kỳ vào productArrayList2.
- Thêm danh sách product ở productArrayList2 vào productArrayList1. (Nghĩa là productArrayList1 sẽ chứa danh sách Product ban đầu + danh sách Product mới từ productArrayList2)
- Thêm một phần tử vào productArrayList1 tại vị trí số 2
- Duyệt qua tất cả phần tử của productArrayList1 và in ra giá trị name và description của mỗi product.

**3. Hastable**

**Lý thuyết:** HashTable là gì: Hastable là một collection trong c# lưu trữ mỗi đối tượng theo cặp key - value. Có thể truy cập value thông qua key.
Tốc độ tìm kiếm qua key của Hastable rất nhanh.

https://upload.wikimedia.org/wikipedia/commons/d/d0/Hash_table_5_0_1_1_1_1_1_LL.svg

Nêu tác dụng của một số thuộc tính và phương thức của HashTable dưới đây?
- Count: Số lượng phần tử hiện có trong Hashtable.
- Keys: 
- Values: 
- Add(Object, Object): 
- Remove(Object): 
- Clone(): 
- ContainsKey(Object): 
- ContainsValue(Object): 

Tham khảo: https://www.tutorialsteacher.com/csharp/csharp-hashtable

**Bài tập**
Tạo ra một HasTable để lưu trữ từ điển Anh-Việt đơn giản có Key là từ Tiếng Anh và Value là từ được dịch sang Tiếng Việt.
Thêm vào HasTable 5 từ vựng.
Duyệt qua các phần tử trong HasTable lấy ra key và value tương ứng.

**4. SortedList**

**Lý thuyết:** 
SortedList là gì: Là một collection trong c# lưu trữ dữ liệu dạng key value giống hashtable nhưng các giá trị được sắp xếp theo key.

Nêu tác dụng của một số thuộc tính và phương thức của SortedList dưới đây?
- Count: 
- Keys: 
- Values: 
- Add(Object, Object): 
- GetByIndex(Int32): 
- SetByIndex(Int32, Object): 
- ContainsKey(Object):
- ContainsValue(Object): 
- Clone(): 

Tham khảo: https://www.tutorialsteacher.com/csharp/csharp-sortedlist

**Bài tập:**
- Tạo một SortedList để lưu trữ các thứ trong tuần với key là number tăng dần (1, 2...7) và value là tên các thứ.
- Thêm các phần tử vào SortedList theo một thứ tự bất kỳ (ví dụ: thứ 5, thứ 4...thứ 2)
- Duyệt qua SortedList và in ra key, value của mỗi phần tử.

**5. Stack là gì?**

Nêu tác dụng của một số thuộc tính và phương thức của Stack dưới đây?
- Count: 
- Push(Object): 
- Pop(): 
- Peek(): 
- Contains(Object): 

Tham khảo: https://docs.microsoft.com/en-us/dotnet/api/system.collections.stack?view=net-6.0

**Bài tập:** Tạo ra một stack chứa các chuỗi: "Hello", "CSharp", ", ", ".Net Core".
Duyệt qua stack và in ra giá trị của mỗi phần tử trong stack. 
Kiểm tra stack có chứa phần tử có giá trị "CSharp" hay không. Có thì in ra giá trị "CSharp", không thì in ra "Not found CSharp".

**6. Queue là gì?**

Nêu tác dụng của một số thuộc tính và phương thức của Stack dưới đây?
- Count: 
- Enqueue(Object): 
- Dequeue(): 
- Peek():
- Contains(Object):

Tham khảo: https://www.tutorialsteacher.com/csharp/csharp-queue

**Bài tập:** Tạo ra một queue lưu trữ các chuỗi: "C#", "JAVA", "JS", "PHP". Duyệt qua queue và in ra giá trị các phần tử.

**GENERIC COLLECTION**

1. Generic là gì? generic là một kỹ thuật cho phép tạo ra các hàm, các lớp mà không cần quan tâm đối số kiểu dữ liệu là gì.
Ví dụ:

```csharp
class Printer
{
    public void Print<T>(T data)
    {
        Console.WriteLine(data);
    }
}

Printer printer = new Printer();
printer.Print<int>(100);
printer.Print(200); // type infer from the specified value
printer.Print<string>("Hello");
printer.Print("World!"); // type infer from the specified value
```

Phương thức Print không cần quan tấm đối số truyền vào hàm kiểu gì. T
được định nghĩa là một generic kiểu chung chỉ xác định từng vào từng giá trị truyền vào cụ thể.


**Generic collection là gì?**
Generic collection là các collection sử dụng kỹ thuật generic. 

Ví dụ: List<T> lúc này T có thể là string, number, boolean, object... tùy vào từng trường hợp cụ thể.

 
 Tham khảo: https://www.tutorialsteacher.com/csharp/csharp-collection
 
**2 List là gì? **

So sánh List và ArrayList?

**Bài tập:** 
Tạo một Class Product chứa các thuộc tính: Id, Name, Description, Price.
Tạo ra 1 productList để lưu trữ danh sách product.
Yêu cầu: 
- Thêm 4 product bất kỳ vào productList.
- Duyệt qua tất cả phần tử của productList và in ra giá trị name và description của mỗi product.

