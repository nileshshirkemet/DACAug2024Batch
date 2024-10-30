class SimpleStack<E> {
    
    private Node top;

    //inner member class can refer to non-static members of outer class
    class Node {

        E entry;
        Node below;

        Node(E value) {
            entry = value;
            below = top;
        }
    }

    public void push(E item) {
        top = new Node(item);
    }

    public E pop() {
        Node node = top;
        top = top.below;
        return node.entry;
    }

    public boolean empty() {
        return top == null;
    }
}
