#include<stdio.h>
#define CAPACITY 3

int stack[CAPACITY];
int top=-1; //that is empty

void push(int x)
{
    if(top < CAPACITY-1)
    {
        top = top + 1;
        stack[top] = x;
        printf("Successfully added item: %d\n", x);
    }
    else
    {
        printf("Exception! No Space\n");
    }

}

int pop()
{
    if(top>=0)
    {
        int val= stack[top];
        top= top-1;
        return val;
    }
    printf("Exception! Stack is empty\n");
    return -1;
}

int peek()
{
    if(top>=0)
    {
        return stack[top];
    }
    printf("Exception from Peek! Empty Stack\n");
    return -1;
}



int main(){
    printf("Implementing my stack in C.\n");
    peek();
    push(5);
    push(10);
    push(15);
    printf("Pop Value: %d\n",pop());
    push(20);
    printf("Peek Value: %d\n",peek());
    return 0;
}
