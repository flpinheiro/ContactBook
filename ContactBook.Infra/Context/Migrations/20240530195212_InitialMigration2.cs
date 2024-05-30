using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactBook.Infra.Context.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ContactAddress_Contact_ContactId",
                table: "ContactAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactDate_Contact_ContactId",
                table: "ContactDate");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactEmail_Contact_ContactId",
                table: "ContactEmail");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactPhone_Contact_ContactId",
                table: "ContactPhone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactPhone",
                table: "ContactPhone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactEmail",
                table: "ContactEmail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactDate",
                table: "ContactDate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactAddress",
                table: "ContactAddress");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.RenameTable(
                name: "ContactPhone",
                newName: "Phones");

            migrationBuilder.RenameTable(
                name: "ContactEmail",
                newName: "Emails");

            migrationBuilder.RenameTable(
                name: "ContactDate",
                newName: "Dates");

            migrationBuilder.RenameTable(
                name: "ContactAddress",
                newName: "Address");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameIndex(
                name: "IX_ContactPhone_ContactId",
                table: "Phones",
                newName: "IX_Phones_ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactEmail_ContactId",
                table: "Emails",
                newName: "IX_Emails_ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactDate_ContactId",
                table: "Dates",
                newName: "IX_Dates_ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_ContactAddress_ContactId",
                table: "Address",
                newName: "IX_Address_ContactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Phones",
                table: "Phones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Emails",
                table: "Emails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dates",
                table: "Dates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Contacts_ContactId",
                table: "Address",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Contacts_ContactId",
                table: "Dates",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Emails_Contacts_ContactId",
                table: "Emails",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Phones_Contacts_ContactId",
                table: "Phones",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Contacts_ContactId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Contacts_ContactId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Emails_Contacts_ContactId",
                table: "Emails");

            migrationBuilder.DropForeignKey(
                name: "FK_Phones_Contacts_ContactId",
                table: "Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Phones",
                table: "Phones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Emails",
                table: "Emails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dates",
                table: "Dates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Phones",
                newName: "ContactPhone");

            migrationBuilder.RenameTable(
                name: "Emails",
                newName: "ContactEmail");

            migrationBuilder.RenameTable(
                name: "Dates",
                newName: "ContactDate");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "ContactAddress");

            migrationBuilder.RenameIndex(
                name: "IX_Phones_ContactId",
                table: "ContactPhone",
                newName: "IX_ContactPhone_ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Emails_ContactId",
                table: "ContactEmail",
                newName: "IX_ContactEmail_ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Dates_ContactId",
                table: "ContactDate",
                newName: "IX_ContactDate_ContactId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_ContactId",
                table: "ContactAddress",
                newName: "IX_ContactAddress_ContactId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactPhone",
                table: "ContactPhone",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactEmail",
                table: "ContactEmail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactDate",
                table: "ContactDate",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactAddress",
                table: "ContactAddress",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactAddress_Contact_ContactId",
                table: "ContactAddress",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactDate_Contact_ContactId",
                table: "ContactDate",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactEmail_Contact_ContactId",
                table: "ContactEmail",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactPhone_Contact_ContactId",
                table: "ContactPhone",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
