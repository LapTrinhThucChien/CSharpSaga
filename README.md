# CSharpSaga


#Collection và Generic collection

1. Collection là gì?


Một số collection phổ biến trong c# như: ArrayList, HashTable, SortedList, Stack, Queue, List.

2.1. Lý thuyết: ArrayList là gì? Nêu tác dụng của một số thuộc tính và phương thức của ArrayList dưới đây:
- Count: 
- Add(Object): 
- AddRange(ICollection): 
- Clone(): 
- Insert(int Index, object Value): 
- Remove(object Value): 

Tham khảo: https://docs.microsoft.com/en-us/dotnet/api/system.collections.arraylist?view=net-6.0

2.2. Bài tập: 
Tạo một Class Product chứa các thuộc tính: Id, Name, Description, Price.
Tạo ra 2 ArrayList để lưu danh sách Product: productArrayList1 và productArrayList2.
Yêu cầu: 
- Thêm 3 product bất kỳ vào productArrayList1 và 2 product bất kỳ vào productArrayList2.
- Thêm danh sách product ở productArrayList2 vào productArrayList1. (Nghĩa là productArrayList1 sẽ chứa danh sách Product ban đầu + danh sách Product mới từ productArrayList2)
- Thêm một phần tử vào productArrayList1 tại vị trí số 2
- Duyệt qua tất cả phần tử của productArrayList1 và in ra giá trị name và description của mỗi product.

3.1 Lý thuyết: HashTable là gì? Nêu tác dụng của một số thuộc tính và phương thức của HashTable dưới đây:
- Count: Số lượng phần tử hiện có trong Hashtable.
- Keys: 
- Values: 
- Add(Object, Object): 
- Remove(Object): 
- Clone(): 
- ContainsKey(Object): 
- ContainsValue(Object): 

3.2 Bài tập 
Tạo ra một HasTable để lưu trữ từ điển Anh-Việt đơn giản có Key là từ Tiếng Anh và Value là từ được dịch sang Tiếng Việt.
Thêm vào HasTable 5 từ vựng.
Duyệt qua các phần tử trong HasTable lấy ra key và value tương ứng.

4.1 Lý thuyết: SortedList là gì? Nêu tác dụng của một số thuộc tính và phương thức của SortedList dưới đây:
- Count: 
- Keys: 
- Values: 
- Add(Object, Object): 
- GetByIndex(Int32): 
- SetByIndex(Int32, Object): 
- ContainsKey(Object):
- ContainsValue(Object): 
- Clone(): 

4.2 Bài tập:
- Tạo một SortedList để lưu trữ các thứ trong tuần với key là number tăng dần (1, 2...7) và value là tên các thứ.
- Thêm các phần tử vào SortedList theo một thứ tự bất kỳ (ví dụ: thứ 5, thứ 4...thứ 2)
- Duyệt qua SortedList và in ra key, value của mỗi phần tử.

5. Stack là gì? Nêu tác dụng của một số thuộc tính và phương thức của Stack dưới đây:
- Count: 
- Push(Object): 
- Pop(): 
- Peek(): 
- Contains(Object): 
6. Queue là gì? Nêu tác dụng của một số thuộc tính và phương thức của Stack dưới đây:
- Count: 
- Enqueue(Object): 
- Dequeue(): 
- Peek():
- Contains(Object):
7.1 List là gì? So sánh List và ArrayList?
7.2 Bài tập: 
Tạo một Class Product chứa các thuộc tính: Id, Name, Description, Price.
Tạo ra 1 productList để lưu trữ danh sách product.
Yêu cầu: 
- Thêm 4 product bất kỳ vào productList.
- Duyệt qua tất cả phần tử của productList và in ra giá trị name và description của mỗi product.
