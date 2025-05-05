
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer_order_and_update
{

}
private void InitializeComponent()
{
    this.labelOrderId = new System.Windows.Forms.Label();
    this.labelCustomerId = new System.Windows.Forms.Label();
    this.labelAmount = new System.Windows.Forms.Label();
    this.labelStatus = new System.Windows.Forms.Label();
    this.txtOrderId = new System.Windows.Forms.TextBox();
    this.txtCustomerId = new System.Windows.Forms.TextBox();
    this.txtAmount = new System.Windows.Forms.TextBox();
    this.txtStatus = new System.Windows.Forms.TextBox();
    this.btnInsert = new System.Windows.Forms.Button();
    this.btnUpdate = new System.Windows.Forms.Button();
    this.SuspendLayout();

    //labelOrderId
    this.labelOrderId.Text = "Order_ID"
    this.labelOrderId.Location = new point
    this.labelOrderId.Size = new size
      
    // txtOrderId
    this.txtOrderId.Location = new System.Drawing.Point(30, 30);
    this.txtOrderId.Size = new System.Drawing.Size(200, 23);

   //labelCustomerId
    this.labelCustomerId.Text = "Customer_ID"
    this.labelCustomerId.Location = new point
    this.labelCustomerId.Size = new size

    // txtCustomerId
    this.txtCustomerId.Location = new System.Drawing.Point(30, 70);
    this.txtCustomerId.Size = new System.Drawing.Size(200, 23);

    //labelAmount
    this.labelAmount.Text = "Order_Amount"
    this.labelAmount.Location = new point
    this.labelAmount.Size = new size
        
    // txtAmount
    this.txtAmount.Location = new System.Drawing.Point(30, 110);
    this.txtAmount.Size = new System.Drawing.Size(200, 23);

    //labelStatus
    this.labelStatus.Text = "Order_Status"
    this.labelStatus.Location = new point
    this.labelStatus.Size = new size

    // txtStatus
    this.txtStatus.Location = new System.Drawing.Point(30, 150);
    this.txtStatus.Size = new System.Drawing.Size(200, 23);

    // btnInsert
    this.btnInsert.Location = new System.Drawing.Point(30, 200);
    this.btnInsert.Name = "btnInsert";
    this.btnInsert.Size = new System.Drawing.Size(90, 30);
    this.btnInsert.Text = "Insert Order";
    this.btnInsert.UseVisualStyleBackColor = true;
    this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);

    // btnUpdate
    this.btnUpdate.Location = new System.Drawing.Point(140, 200);
    this.btnUpdate.Name = "btnUpdate";
    this.btnUpdate.Size = new System.Drawing.Size(90, 30);
    this.btnUpdate.Text = "Update Order";
    this.btnUpdate.UseVisualStyleBackColor = true;
    this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

    // MainForm
    this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(284, 261);
    this.Controls.Add(this.labelOrderId);
    this.Controls.Add(this.labelCustomerId);
    this.this.Controls.Add(this.labelAmount);
    this.Controls.Add(this.labelStatus);    
    this.Controls.Add(this.txtOrderId);
    this.Controls.Add(this.txtCustomerId);
    this.Controls.Add(this.txtAmount);
    this.Controls.Add(this.txtStatus);
    this.Controls.Add(this.btnInsert);
    this.Controls.Add(this.btnUpdate);
    this.Name = "MainForm";
    this.Text = "Customer Order App";
    this.ResumeLayout(false);
    this.PerformLayout();
}

// Declare controls
private System.Windows.Forms.TextBox txtOrderId;
private System.Windows.Forms.TextBox txtCustomerId;
private System.Windows.Forms.TextBox txtAmount;
private System.Windows.Forms.TextBox txtStatus;
private System.Windows.Forms.Button btnInsert;
private System.Windows.Forms.Button btnUpdate;
