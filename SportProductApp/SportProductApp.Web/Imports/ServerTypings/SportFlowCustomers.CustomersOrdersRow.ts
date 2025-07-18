namespace SportProductApp.SportFlowCustomers {
    export interface CustomersOrdersRow {
        OrderId?: number;
        PublicId?: string;
        CustomerId?: number;
        Address?: string;
        DateCreated?: string;
        Status?: SportFlow.Order.Enums.OrderStatusKind;
        CustomerPublicId?: string;
        CustomerUserId?: number;
        CustomerName?: string;
        CustomerCreditCard?: string;
        CustomerDateCreated?: string;
    }

    export namespace CustomersOrdersRow {
        export const idProperty = 'OrderId';
        export const nameProperty = 'PublicId';
        export const localTextPrefix = 'SportFlowCustomers.CustomersOrders';
        export const deletePermission = 'Customers:General';
        export const insertPermission = 'Customers:General';
        export const readPermission = 'Customers:General';
        export const updatePermission = 'Customers:General';

        export declare const enum Fields {
            OrderId = "OrderId",
            PublicId = "PublicId",
            CustomerId = "CustomerId",
            Address = "Address",
            DateCreated = "DateCreated",
            Status = "Status",
            CustomerPublicId = "CustomerPublicId",
            CustomerUserId = "CustomerUserId",
            CustomerName = "CustomerName",
            CustomerCreditCard = "CustomerCreditCard",
            CustomerDateCreated = "CustomerDateCreated"
        }
    }
}

