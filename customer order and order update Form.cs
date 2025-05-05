
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customer order and order update
{

}
private void customer order and order update Form()
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

    //labeltitle
    this.labeltitle.Font = new System.Drawing.Font("Segoe UI", 9F, FontStyle.Regular);
    this.labeltitle.Location = new System.Drawing.Point(12, 9);
    this.labeltitle.Size = new System.Drawing.Size(816, 489);
    this.labeltitle.Text = " customer order and order update";
    this.labeltitle.TextAlign = ContentAlignment.MiddleCenter;
    
    //labelOrderId
    this.labelOrderId.Text = "Order_ID"
    this.labelOrderId.Location = new System.Drawing.Point(236, 31);
    this.labelOrderId.Size = new System.Drawing.Size(53, 15);
    
    // txtOrderId
    this.txtOrderId.Location = new System.Drawing.Point(297, 28);
    this.txtOrderId.Size = new System.Drawing.Size(200, 23);

   //labelCustomerId
    this.labelCustomerId.Text = "Customer_ID"
    this.labelCustomerId.Location = new System.Drawing.Point(214, 74);
    this.labelCustomerId.Size = new System.Drawing.Size(75, 15);

    // txtCustomerId
    this.txtCustomerId.Location = new System.Drawing.Point(297, 71);
    this.txtCustomerId.Size = new System.Drawing.Size(200, 23);

    //labelAmount
    this.labelAmount.Text = "Order_Amount"
    this.labelAmount.Location = new System.Drawing.Point(203, 116);
    this.labelAmount.Size = new System.Drawing.Size(86, 15);
        
    // txtAmount
    this.txtAmount.Location = new System.Drawing.Point(297, 116);
    this.txtAmount.Size = new System.Drawing.Size(200, 23);

    //labelStatus
    this.labelStatus.Text = "Order_Status"
    this.labelStatus.Location = new System.Drawing.Point(215, 165);
    this.labelStatus.Size = new System.Drawing.Size(74, 15);

    // txtStatus
    this.txtStatus.Location = new System.Drawing.Point(297, 165);
    this.txtStatus.Size = new System.Drawing.Size(200, 23);

    // btnInsert
    this.btnInsert.Location = new System.Drawing.Point(545, 48);
    this.btnInsert.Name = "btnInsert";
    this.btnInsert.Size = new System.Drawing.Size(90, 30);
    this.btnInsert.Text = "Insert Order";
    this.btnInsert.UseVisualStyleBackColor = true;
    this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);

    // btnUpdate
    this.btnUpdate.Location = new System.Drawing.Point(545, 138);
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
    this.Controls.Add(this.labelAmount);
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
private System.Windows.Forms.Label labelOrderId;
private System.Windows.Forms.Label labelCustomerId;
private System.Windows.Forms.Label labelAmount;
private System.Windows.Forms.Label labelStatus;
private System.Windows.Forms.TextBox txtOrderId;
private System.Windows.Forms.TextBox txtCustomerId;
private System.Windows.Forms.TextBox txtAmount;
private System.Windows.Forms.TextBox txtStatus;
private System.Windows.Forms.Button btnInsert;
private System.Windows.Forms.Button btnUpdate;
