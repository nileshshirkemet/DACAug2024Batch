from sys import argv
from grpc import insecure_channel, RpcError
from order_manager_pb2 import OrderInput, CustomerInput
from order_manager_pb2_grpc import OrderManagerStub

custid = argv[1].upper()
with insecure_channel('localhost:4030') as channel:
    remote = OrderManagerStub(channel)
    if(len(argv) > 3):
        pno = int(argv[2])
        qty = int(argv[3])
        request = OrderInput(customer_code = custid, item_code = pno, item_count = qty)
        try:
            reply = remote.PlaceOrder(request)
            print('New order number is', reply.confirmation_code)
        except RpcError as fault:
            print(fault.details())
    else:
        request = CustomerInput(customer_code = custid)
        reply = remote.FetchOrders(request)
        for entry in reply:
            print(f'{entry.item_code}\t{entry.item_count}\t{entry.confirmation_date}')

#pip install grpcio grpcio.tools
#python -m grpc_tools.protoc --python_out=. --grpc_python_out=. order_manager.proto -I .
