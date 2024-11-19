//const backendUri = "http://localhost:5000/api/sales";
const backendUri = "rest/api/sales";

class SalesDataSource {

    constructor() {
        this.orderList = [];
        this.orderEntry = {customerId: "", productNo: 0, quantity: 0};
        this.statusReport = "";
    }

    async readOrders() {
        this.orderList = [];
        let response = await fetch(`${backendUri}/${this.orderEntry.customerId}`);
        if(response.ok){
            this.orderList = await response.json();
            this.statusReport = "";
        }else{
            this.statusReport = "Cannot load orders!";
        }
    }

    async createOrder() {
        this.orderList = [];
        let request = {
            method: "post",
            headers: {"Content-Type": "application/json"},
            body: JSON.stringify(this.orderEntry)
        };
        let response = await fetch(backendUri, request);
        if(response.ok){
            let result = await response.json();
            this.statusReport = `Order ${result.orderNo} placed.`;
        }else{
            this.statusReport = "Cannot place order!";
        }
    }
}
