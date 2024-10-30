import java.util.Iterator;

class SimpleStack<E> implements Iterable<E> {
    
    private Node top;

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

    //in order to support standard iteration a class must
    //expose iterator() method which returns an object of
    //java.util.Iterator<T> type
    public Iterator<E> iterator() {
        //returning an instance of an inner local anonymous class
        //which implements Iterator<E>
        return new Iterator<E>(){
            
            private Node current = top;

            public boolean hasNext() {
                return current != null;
            }

            public E next() {
                E item = current.entry;
                current = current.below;
                return item;
            }
        };
    }
}
