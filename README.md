# 📝 Bài Tập 4.2 – Form Đăng Ký Học Viên

Bài tập xây dựng form đăng ký học viên sử dụng đa dạng các Input Controls trong Windows Forms C#.

---

## 📋 Mô tả

Form đăng ký học viên với các loại control phổ biến:
- **MaskedTextBox** nhập số điện thoại theo định dạng `(000) 000-0000`
- **DateTimePicker** chọn ngày sinh (định dạng ngắn `dd/MM/yyyy`)
- **ComboBox** liên kết dữ liệu danh sách khóa học (`DisplayMember` / `ValueMember`)
- **CheckBox** chọn môn học bổ sung
- Nút **Đăng Ký** tổng hợp và hiển thị thông tin trên MessageBox

---

## 🖼️ Giao diện

### Form chính và kết quả đăng ký
![Form đăng ký học viên](Screenshot%202026-09-23%20164224.png)

### Danh sách khóa học trong ComboBox
![Danh sách khóa học](Screenshot%202026-09-23%20164341.png)

---

## ⚙️ Các thành phần chính

| Tên Control | Chức năng |
|-------------|-----------|
| `txtFullName` | Ô nhập họ và tên |
| `dtpBirthDate` | Chọn ngày sinh — định dạng `dd/MM/yyyy` |
| `mtxtPhone` | Nhập SĐT theo Mask `(000) 000-0000` |
| `cboCourse` | Chọn khóa học từ danh sách |
| `chkEnglish` | Chọn môn Tiếng Anh |
| `chkSoftSkills` | Chọn môn Kỹ năng mềm |
| `chkIT` | Chọn môn Tin học văn phòng |
| `btnRegister` | Tổng hợp & in thông tin đăng ký |
| `btnClear` | Xóa trắng toàn bộ form |

---

## 🚀 Cách chạy

**Bằng Visual Studio:**
1. Mở file `BT4_2_StudentRegistration.sln`
2. Nhấn `F5` để chạy

**Bằng terminal:**
```bash
dotnet run
```

---

## 🛠️ Yêu cầu
- .NET 10.0 SDK
- Windows OS
- Visual Studio 2022 trở lên
