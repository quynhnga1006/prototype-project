# Prototype Pattern - Order Clone Example
Bài toán
Trong hệ thống quản lý đơn hàng, đôi khi cần tạo ra các bản sao (clone) của một đơn hàng gốc để phục vụ các mục đích như tạo báo cáo, xử lý đơn hàng mẫu, hoặc tạo đơn hàng mới dựa trên thông tin có sẵn. Việc khởi tạo lại toàn bộ đơn hàng từ đầu sẽ tốn thời gian và dễ sai sót, đặc biệt với các đối tượng phức tạp.

Yêu cầu
Cho phép clone một đơn hàng từ đơn hàng gốc.
Đảm bảo các thuộc tính của đơn hàng clone giống với đơn hàng gốc, có thể chỉnh sửa một số thông tin nếu cần.
Dễ dàng mở rộng, áp dụng cho các đối tượng khác trong hệ thống.
Giải pháp: Prototype Pattern