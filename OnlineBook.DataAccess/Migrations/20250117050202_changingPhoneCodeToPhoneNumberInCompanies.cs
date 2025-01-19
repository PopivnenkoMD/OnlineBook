using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class changingPhoneCodeToPhoneNumberInCompanies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneCode",
                table: "Companies",
                newName: "PhoneNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Companies",
                newName: "PhoneCode");
        }
    }
}
