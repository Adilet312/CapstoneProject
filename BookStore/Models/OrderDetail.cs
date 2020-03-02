/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Adilet 
 */
public class OrderDetail {
    private Long id;
    private Long productId;
    private Long orderId;
    private Integer quantity;
    public OrderDetail()
    {
        
    }

    /**
     * @return the id
     */
    public Long getId() {
        return id;
    }

    /**
     * @param id the id to set
     */
    public void setId(Long id) {
        this.id = id;
    }

    /**
     * @return the ProductId
     */
    public Long getProductId() {
        return productId;
    }

    /**
     * @param ProductId the ProductId to set
     */
    public void setProductId(Long ProductId) {
        this.productId = ProductId;
    }

    /**
     * @return the OrderId
     */
    public Long getOrderId() {
        return orderId;
    }

    /**
     * @param OrderId the OrderId to set
     */
    public void setOrderId(Long OrderId) {
        this.orderId = OrderId;
    }

    /**
     * @return the quantity
     */
    public Integer getQuantity() {
        return quantity;
    }

    /**
     * @param quantity the quantity to set
     */
    public void setQuantity(Integer quantity) {
        this.quantity = quantity;
    }
    /**
     * @return the string representation of Order detail
    **/
    public String toString()
    {
        String output = "Order Detail{ " +
                        "Id: "          + this.id +
                        ", ProductId: " + this.productId + 
                        ", OrderId: "   + this.orderId +
                        ", Quantity: "  + this.quantity +
                        " }";
        return output;
    }
    
}
