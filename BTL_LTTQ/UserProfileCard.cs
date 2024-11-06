using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MaterialSkin.Controls;
namespace Client;
public partial class UserProfileCard : UserControl
{
    public UserProfileCard(string username,Image avt)
    {
        InitializeComponent();
        this.Avatar = avt;
        this.Name = username;
        usernameLabel.Text = username;
        this.Size = new Size(200, 320);

        // Cấu hình các thành phần
        usernameLabel.TextAlign = ContentAlignment.MiddleCenter;

        addFriendButton.Text = "Thêm bạn bè";

        // Gọi phương thức để bo góc ảnh
        avatarPictureBox.Paint += AvatarPictureBox_Paint;
    }

    private void AvatarPictureBox_Paint(object sender, PaintEventArgs e)
    {
        Rectangle rect = new Rectangle(0, 0, avatarPictureBox.Width, avatarPictureBox.Height);
        int cornerRadius = 20; // Độ bo góc

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(rect.X, rect.Y, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rect.X + rect.Width - cornerRadius, rect.Y, cornerRadius, cornerRadius, 270, 90);
            path.AddRectangle(new Rectangle(rect.X, rect.Y + cornerRadius / 2, rect.Width, rect.Height - cornerRadius / 2));

            avatarPictureBox.Region = new Region(path);
        }
    }

    // Thuộc tính công khai để thiết lập tên người dùng
    public string Username
    {
        get => usernameLabel.Text;
        set => usernameLabel.Text = value;
    }

    // Thuộc tính công khai để thiết lập thông tin phụ (số bạn chung)

    // Thuộc tính công khai để thiết lập ảnh đại diện
    public Image Avatar
    {
        get => avatarPictureBox.Image;
        set => avatarPictureBox.Image = value;
    }
}
