namespace SportProductApp.SportFlow {
    export interface OrderDetailsRow {
        OrderDetailId?: number;
        OrderId?: number;
        ProductId?: number;
        Quantity?: number;
        PriceSnapshot?: number;
        OrderPublicId?: string;
        OrderCustomerId?: number;
        OrderStatus?: string;
        OrderAddress?: string;
        OrderDateCreated?: string;
        ProductPublicId?: string;
        ProductName?: string;
        ProductPrice?: number;
        ProductDateCreated?: string;
    }

    export namespace OrderDetailsRow {
        export const idProperty = 'OrderDetailId';
        export const localTextPrefix = 'SportFlow.OrderDetails';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            OrderDetailId = "OrderDetailId",
            OrderId = "OrderId",
            ProductId = "ProductId",
            Quantity = "Quantity",
            PriceSnapshot = "PriceSnapshot",
            OrderPublicId = "OrderPublicId",
            OrderCustomerId = "OrderCustomerId",
            OrderStatus = "OrderStatus",
            OrderAddress = "OrderAddress",
            OrderDateCreated = "OrderDateCreated",
            ProductPublicId = "ProductPublicId",
            ProductName = "ProductName",
            ProductPrice = "ProductPrice",
            ProductDateCreated = "ProductDateCreated"
        }
    }
}

